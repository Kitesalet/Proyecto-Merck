using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Enums;
using ProyectoMerck.Models.ViewModels;

namespace Proyecto_Merck.Controllers
{
    public class IndicatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Indicator(ReserveVM level) 
        {


            return View(level);
        }
    }
}
