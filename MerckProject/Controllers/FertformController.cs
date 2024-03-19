using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Resources;
using ProyectoMerck.Utilities;
using System;
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
        public IActionResult FertilityCalculator(FertformVM model) //dxdfsojgofgipdfl
        {
            string culture = CultureHelper.GetCultureFromCookie(HttpContext.Request.Cookies[".AspNetCore.Culture"]);
            bool errorFlag = false;
            ResourceManager manager = new ResourceManager(_ValidationResourceLocation, typeof(ValidationResources).Assembly);
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            int monthAge = currentMonth - model.SelectedDate.Month;
            int yearAge = currentYear - model.SelectedDate.Year;

            //Revisa si la persona todavía no cumplio años en ese mismo año
            if (monthAge == 0)
            {
                //Si justo ese mes cumplio años, queda 1
                monthAge = 1;
            }
            else if(monthAge < 0)
            {
                //Si todavía no cumplio años, se le resta 1 año a su edad actual
                yearAge--;

                //Como el numero queda negativo, se suma a 12 para tener los meses actuales
                monthAge = 12 + monthAge;
            }            
    
            model.SelectedYear = yearAge;
            model.SelectedMonth = monthAge;

            int questionUserInt;
            if (int.TryParse(model.QuestionUser, out questionUserInt))
            {

                //Valida que las edades sean validas en base a los limites del grafico, se puede convertir en un service
                if (model.SelectedYear > 40 && questionUserInt == 11 ||
                   model.SelectedYear > 40 && questionUserInt == 10 ||
                   model.SelectedYear > 44 && questionUserInt == 6 ||
                   model.SelectedYear > 47 && questionUserInt == 3)
                {
                    errorFlag = true;
                }

                if (errorFlag)
                {
                    TempData["Error"] = $"No puede elegir esa opcion teniendo su edad actual!";
                    ModelState.AddModelError("InvalidAges", $"No puede elegir esa opcion teniendo su edad actual!");
                    return View("Index", model);
                }

                //Solo funciona poniendo -1, es un tema de la ecuacion
                int ageInMonths = (yearAge * 12) + monthAge - 1;
                double ovocites = FertCalculator.CalculateFollicles(ageInMonths);
                double folicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, ovocites);
                int oldSelectedYear = model.SelectedYear;


                List<Tuple<string, double>> dataValues = new List<Tuple<string, double>>();

                switch (questionUserInt)
                {
                    case 3://

                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 0)
                            {

                                dataValues.Add(Tuple.Create<string, double>($"AÑOS {model.SelectedYear}", folicularOvocites));
                                model.SelectedYear++;

                            }
                            else
                            {

                                ageInMonths += 12;
                                double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                                dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                                model.SelectedYear++;

                            }

                        }

                        break;

                    case 6:

                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 0)
                            {
                                ageInMonths += 48;
                                model.SelectedYear += 4;

                            }

                            double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                            double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                            ageInMonths += 12;                          
                            dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                            model.SelectedYear++;

                        }

                        break;

                    case 10:

                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 0)
                            {
                                ageInMonths += 84;
                                model.SelectedYear += 7;

                            }

                            double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                            double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                            ageInMonths += 12;
                            dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                            model.SelectedYear++;


                        }

                        break;

                    case 11:

                        ageInMonths += 120;
                        model.SelectedYear += 10;
                        int finalValue = 50 - model.SelectedYear;

                        for (int i = model.SelectedYear; i <= 50; i++)
                        {

                            double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                            double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                            ageInMonths += 12;
                            dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                            model.SelectedYear++;

                        }

                        break;

                    case 0:

                        for (int i = model.SelectedYear; i <= 50; i++)
                        {

                            double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                            double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                            ageInMonths += 12;
                            dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                            model.SelectedYear++;

                        }

                        break;
                }

                //Paso a JSON la matriz de ovocitos creada arriba
                string ovoMatrixJson = JsonConvert.SerializeObject(dataValues);


                return RedirectToAction("Index", "Reserve", new
                {
                    OvoCount = folicularOvocites,
                    SelectedYear = oldSelectedYear,
                    QuestionUser = questionUserInt,
                    OvoMatrix = ovoMatrixJson
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
