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
            bool errorFlag = false;
            ResourceManager manager = new ResourceManager(_ValidationResourceLocation, typeof(ValidationResources).Assembly);


            int questionUserInt;
            if (int.TryParse(model.QuestionUser, out questionUserInt))
            {

                //Valida que las edades sean validas en base a los limites del grafico, se puede convertir en un service
                if(model.SelectedYear > 40 && questionUserInt == 11 ||
                   model.SelectedYear > 40 && questionUserInt == 10 ||
                   model.SelectedYear > 44 && questionUserInt == 6  ||
                   model.SelectedYear > 47 && questionUserInt == 3)
                {
                    errorFlag = true;
                }

                if (!errorFlag)
                {
                    TempData["Error"] = $"No puede elegir esa opcion teniendo su edad actual!";
                    ModelState.AddModelError("InvalidAges", $"No puede elegir esa opcion teniendo su edad actual!");
                    return View("Index", model);
                }

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
                TempData["Error"] = $"No puede elegir esa opción teniendo {questionUserInt}!";
                ModelState.AddModelError("InvalidAges", $"No puede elegir esa opción teniendo {questionUserInt}!");
                return View("Index", model);
            }
        }




    }
}
