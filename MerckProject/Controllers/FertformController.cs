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

            if (int.Parse(model.CurrentAge) < int.Parse(model.FirstFertilityAge) || int.Parse(model.CurrentAge) > int.Parse(model.QuestionUser))
            {
                TempData["Error"] = manager.GetString("InvalidAges");
                ModelState.AddModelError("InvalidAges", manager.GetString("InvalidAges"));
                return View("Index", model);
            }

            double ovocites = FertCalculator.CalculateOvocites(int.Parse(model.CurrentAge));

            return RedirectToAction("Index", "Reserve", new
            {
                FertilityLevel = ovocites,
                CurrentAge = model.CurrentAge,
                QuestionUser = model.QuestionUser,
                FirstAge = model.FirstFertilityAge
            });
        }



    }
}
