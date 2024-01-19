using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.ViewModels;

namespace Proyecto_Merck.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(SignInManager<IdentityUser> user)
        {

            _signInManager = user;

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {

            if (ModelState.IsValid)
            {

                IdentityUser user = new IdentityUser()
                {

                    UserName = model.Username,
                    Email = model.Username

                };

                var logged = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

                if(logged.Succeeded)
                {
                    return RedirectToAction("Index", "Reports");
                }
                else
                {
                    TempData["LoginError"] = "Error";
                    ModelState.AddModelError("", "El usuario no existe y/o las credenciales son incorrectas");
                }

            }


            return View("Index",model);
            



        }

        public IActionResult Index()
        {



            return View();
        }
    }
}
