﻿using MerckProject.Resources;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;
using System.Resources;

namespace MerckProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IRegexHelper _regexHelper;
        private const string _validationResourceLocation = "ProyectoMerck.Resources.ValidationResources"; 

        public LoginController(SignInManager<IdentityUser> user, IRegexHelper regexHelper, UserManager<IdentityUser> userManager)
        {

            _signInManager = user;
            _regexHelper = regexHelper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {

            string culture = CultureHelper.GetCultureFromCookie(HttpContext.Request.Cookies[".AspNetCore.Culture"]);

            model.CurrentCulture = culture;

            ResourceManager manager = new ResourceManager(_validationResourceLocation, typeof(ConsultationResources).Assembly);

            if (!_regexHelper.ValidEmail(model.Email))
            {
                ModelState.AddModelError("Email", manager.GetString("Email"));
                TempData["Error"] = manager.GetString("Email");

            }

            if (ModelState.IsValid)
            {

                //IdentityUser user = new IdentityUser()
                //{
                //    Email = model.Email,
                //    UserName = model.Email
                //};

                //try
                //{
                //    await _userManager.CreateAsync(user, model.Password);

                //}
                //catch
                //{

                //}

                var logged = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);

                if(logged.Succeeded)
                {
                    return RedirectToAction("Reports", "Reports");
                }
                else
                {
                    TempData["Error"] = manager.GetString("NonExistingUser");
                    ModelState.AddModelError("IncorrectCredentials", manager.GetString("NonExistingUser"));
                }

            }

            return View("Index",model);

        }

        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Index()
        {

            LoginVM model = new LoginVM();

            string culture = CultureHelper.GetCultureFromCookie(HttpContext.Request.Cookies[".AspNetCore.Culture"]);

            model.CurrentCulture = culture;

            return View(model);
        }
    }
}
