using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Enums;

namespace Proyecto_Merck.Controllers
{
    public class IndicatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Indicator(FertilityLevel level) 
        {


            return View(level);
        }
    }
}
