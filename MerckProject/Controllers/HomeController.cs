using Microsoft.AspNetCore.Mvc;
using Proyecto_Merck.Models;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;
using System.Diagnostics;

namespace MerckProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            HomeVM model = new HomeVM();

            try
            {
                model.CurrentCulture = CultureHelper.GetCultureFromCookie(HttpContext.Request.Cookies[".AspNetCore.Culture"]);
            }
            catch
            {

            }

            return View(model);
        }
    }
}
