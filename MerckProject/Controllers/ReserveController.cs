﻿using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Enums;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;

namespace MerckProject.Controllers
{
    public class ReserveController : Controller
    {
        public IActionResult Index(ReserveVM model)
        {

            return View(model);

        }

        public IActionResult RedirectIndicator(ReserveVM model)
        {

            FertilityLevel fertLevel = FertCalculator.FertLevelCalculator(model.SelectedYear);


            return RedirectToAction("Indicator", "Indicator", new
            {
                FertilityLevel = model.FertilityLevel,
                CurrentAge = model.SelectedYear,
                QuestionUser = model.QuestionUser,
                OvoCount = Math.Round(model.OvoCount,2)
            });

        }
    }
}
