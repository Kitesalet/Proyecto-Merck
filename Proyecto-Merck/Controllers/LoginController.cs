using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;

namespace Proyecto_Merck.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IRegexHelper _regexHelper;

        public LoginController(SignInManager<IdentityUser> user, IRegexHelper regexHelper)
        {

            _signInManager = user;
            _regexHelper = regexHelper;

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {

            if (!_regexHelper.ValidEmail(model.Email))
            {
                ModelState.AddModelError("Email", "El email ingresado es invalido!");
                TempData["Error"] = "El email ingresado es invalido!";

            }

            if (ModelState.IsValid)
            {

                var logged = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);

                if(logged.Succeeded)
                {
                    return RedirectToAction("Reports", "Reports");
                }
                else
                {
                    TempData["Error"] = "El usuario no existe y/o las credenciales son incorrectas";
                    ModelState.AddModelError("IncorrectCredentials", "El usuario no existe y/o las credenciales son incorrectas");
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



            return View();
        }
    }
}
