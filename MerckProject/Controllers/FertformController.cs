using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;

namespace MerckProject.Controllers
{
    public class FertformController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult FertilityCalculator(FertformVM model)
        {
            if(int.Parse(model.CurrentAge) < int.Parse(model.FirstFertilityAge))
            {
                TempData["Error"] = "Las edades ingresadas son invalidas";
                ModelState.AddModelError("Invalid Ages", "Las edades ingresadas son invalidas!");
            }

            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            double ovocites = FertCalculator.CalculateOvocites(int.Parse(model.CurrentAge));

            return RedirectToAction("Index", "Reserve", new {FertilityLevel = ovocites , CurrentAge = model.CurrentAge, FirstAge = model.FirstFertilityAge});
        }
    }
}
