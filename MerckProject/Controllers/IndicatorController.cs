using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Enums;
using ProyectoMerck.Models.ViewModels;

namespace MerckProject.Controllers
{
    public class IndicatorController : Controller
    {
        private readonly ILogger<IndicatorController> _logger;

        public IndicatorController(ILogger<IndicatorController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            _logger.LogInformation("Accesed Indicator Index screen");

            return View();
        }

        public IActionResult Indicator(ReserveVM level) 
        {

            _logger.LogInformation("Accesed Indicator Indicator screen");

            return View(level);
        }
    }
}
