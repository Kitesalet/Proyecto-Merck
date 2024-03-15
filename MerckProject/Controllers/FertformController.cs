using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Resources;
using ProyectoMerck.Utilities;
using System.Resources;

namespace MerckProject.Controllers
{
    public class FertformController : Controller
    {
        private const string _ValidationResourceLocation = "ProyectoMerck.Resources.ValidationResources";


        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult FertilityCalculator(FertformVM model)
        {
            string culture = CultureHelper.GetCultureFromCookie(HttpContext.Request.Cookies[".AspNetCore.Culture"]);
            ResourceManager manager = new ResourceManager(_ValidationResourceLocation, typeof(ValidationResources).Assembly);

            int questionUserInt;
            if (int.TryParse(model.QuestionUser, out questionUserInt))
            {

                double ovocites = FertCalculator.CalculateOvocites(model.SelectedYear, model.SelectedMonth, questionUserInt);

                return RedirectToAction("Index", "Reserve", new
                {
                    FertilityLevel = ovocites,
                    OvoCount = Math.Round(ovocites, 2),
                    SelectedYear = model.SelectedYear,
                    SelectedMonth = model.SelectedMonth,
                    QuestionUser = questionUserInt,
                });
            }
            else
            {
                // Manejar el caso de error si la conversión falla
                TempData["Error"] = manager.GetString("InvalidAges");
                ModelState.AddModelError("InvalidAges", manager.GetString("InvalidAges"));
                return View("Index", model);
            }
        }




    }
}
