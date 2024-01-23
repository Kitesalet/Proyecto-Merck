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

                var logged = await _signInManager.PasswordSignInAsync(model.Username, model.Password, true, false);

                if(logged.Succeeded)
                {
                    return RedirectToAction("Reports", "Reports");
                }
                else
                {
                    TempData["Error"] = "El usuario no existe y/o las credenciales son incorrectas";
                    ModelState.AddModelError("", "El usuario no existe y/o las credenciales son incorrectas");
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
