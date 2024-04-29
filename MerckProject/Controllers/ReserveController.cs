using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Enums;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;

namespace MerckProject.Controllers
{
    public class ReserveController : Controller
    {
        private readonly ILogger<ReserveController> _logger;

        public ReserveController(ILogger<ReserveController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(ReserveVM model)
        {
            _logger.LogInformation("Accesing Reserve Index screen");

            

            return View(model);

        }

        public IActionResult RedirectIndicator(ReserveVM model)
        {

            FertilityLevel fertLevel = FertCalculator.FertLevelCalculator(model.SelectedYear);

            _logger.LogInformation("Clicked the redirect button in Reserve Controller with the data aside");


            return RedirectToAction("Indicator", "Indicator", new
            {
                FertilityLevel = fertLevel,
                SelectedYear = model.SelectedYear,
                QuestionUser = model.QuestionUser,
                OvoCount = Math.Round(model.OvoCount,2)
            });

        }
    }
}
