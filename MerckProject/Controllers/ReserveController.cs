using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Enums;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;

namespace MerckProject.Controllers
{
    public class ReserveController : Controller
    {
        private readonly ILogger<ReserveController> _logger;
        private readonly HttpContext _httpContext;

        public ReserveController(ILogger<ReserveController> logger, IHttpContextAccessor httpContext)
        {
            _logger = logger;
            _httpContext = httpContext.HttpContext;
        }
        public IActionResult Index(ReserveVM model)
        {
            _logger.LogInformation("Accesing Reserve Index screen");

            

            return View(model);

        }

        public IActionResult BackToIndex(ReserveVM model)
        {

            return Redirect(model.Referer);
        }

        public IActionResult RedirectIndicator(ReserveVM model)
        {

            FertilityLevel fertLevel = FertCalculator.FertLevelCalculator(model.SelectedYear);

            _logger.LogInformation("Clicked the redirect button in Reserve Controller with the data aside");

            model.Referer = _httpContext.Request.Headers["referer"].ToString();

            return RedirectToAction("Indicator", "Indicator", new
            {
                FertilityLevel = fertLevel,
                SelectedYear = model.SelectedYear,
                QuestionUser = model.QuestionUser,
                OvoCount = Math.Round(model.OvoCount, 2),
                Referer = model.Referer
            });

        }
    }
}
