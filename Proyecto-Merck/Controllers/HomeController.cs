using Microsoft.AspNetCore.Mvc;
using Proyecto_Merck.Models;
using System.Diagnostics;

namespace Proyecto_Merck.Controllers
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
            return View();
        }


    }
}
