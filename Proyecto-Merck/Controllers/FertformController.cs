using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.ViewModels;

namespace Proyecto_Merck.Controllers
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
                ModelState.AddModelError("Invalid Ages", "Las edades ingresadas son invalidas!");
            }

            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return RedirectToAction("Index", "Reserve", new {FertilityLevel = 400, CurrentAge = model.CurrentAge, FirstAge = model.FirstFertilityAge});
        }
    }
}
