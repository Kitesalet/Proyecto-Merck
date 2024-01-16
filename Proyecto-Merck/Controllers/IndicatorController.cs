using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Merck.Controllers
{
    public class IndicatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Indicator() 
        {
            return View();
        }
    }
}
