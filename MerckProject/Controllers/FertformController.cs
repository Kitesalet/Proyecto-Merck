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
        private readonly ILogger<FertformController> _logger;

        public FertformController(ILogger<FertformController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accesed fertform index screen");
            return View();
        }

        [HttpPost]
        public IActionResult FertilityCalculator(FertformVM model) //dxdfsojgofgipdfl
        {
            _logger.LogInformation("Submitted the formulary from the fertfom index screen");


            if (model.SelectedDate == DateTime.MinValue)
            {
                TempData["Error"] = "Por favor, seleccione una fecha valida";

                _logger.LogError("Invalid age setted up at the fertility form");

                return View(nameof(Index), model);
            }

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
                   model.SelectedYear > 47 && questionUserInt == 3 ||
                   model.SelectedYear < 12)
                {
                    errorFlag = true;
                }

                if (errorFlag)
                {
                    TempData["Error"] = $"No puede elegir esa opcion teniendo su edad: {model.SelectedYear}!";
                    ModelState.AddModelError("InvalidAges", $"No puede elegir esa opcion teniendo su edad actual!");
                    _logger.LogError("There was an error in the selected option whilst having sleected an the users actual age");

                    return View("Index", model);
                }

                //Solo funciona poniendo -1, es un tema de la ecuacion
                int ageInMonths = (yearAge * 12) + monthAge - 1;
                double ovocites = FertCalculator.CalculateFollicles(ageInMonths);
                double folicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, ovocites);

                //para calcular el endlimit del grafico
                int oldSelectedYear = model.SelectedYear;
                int endLimitYear = 0;
                double endFolicularOvocites = 0;


                List<Tuple<string, double>> dataValues = new List<Tuple<string, double>>();

                switch (questionUserInt)
                {
                    case 3:

                        endLimitYear = oldSelectedYear + 3;
                        if (endLimitYear >= 50)
                        {
                            endLimitYear = 50;
                            //endOvocites = FertCalculator.CalculateFollicles((yearAge * 12) - 1);
                            //endFolicularOvocites = FertCalculator.CalculateEuploidFollicles(oldSelectedYear, endOvocites);
                        }

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

                                endFolicularOvocites = newFolicularOvocites;

                            }

                        }

                        break;

                    case 6:

                        endLimitYear = oldSelectedYear + 7;
                        if (endLimitYear >= 50)
                        {
                            endLimitYear = 50;
                        }

                        for (int i = 0; i <= 3; i++)
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
                            endFolicularOvocites = newFolicularOvocites;

                        }

                        break;

                    case 10:

                        endLimitYear = oldSelectedYear + 10;
                        if (endLimitYear >= 50)
                        {
                            endLimitYear = 50;
                        }

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
                            endFolicularOvocites = newFolicularOvocites;

                        }

                        break;

                    case 11:

                        endLimitYear = 50;
                        ageInMonths += 120;
                        model.SelectedYear += 10;
                        int finalValue = 50 - model.SelectedYear;

                        #region escala 

                        if (oldSelectedYear < 30)
                        {     

                            for (int i = model.SelectedYear; i <= 50; i++)
                            {

                                if (model.SelectedYear <= 50)
                                {
                                    double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                    double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                                    ageInMonths += 36;
                                    dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                                    if (model.SelectedYear == 50)
                                    {
                                        break;
                                    }
                                    model.SelectedYear++;
                                    model.SelectedYear++;
                                    model.SelectedYear++;
                                    endFolicularOvocites = newFolicularOvocites;

                                }
                                else if (model.SelectedYear > 50)
                                {
                                    double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                    double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(50, newOvo);
                                    dataValues.Add(Tuple.Create<string, double>($"50 AÑOS", newFolicularOvocites));
                                    model.SelectedYear++;
                                    endFolicularOvocites = newFolicularOvocites;

                                    break;
                                }

                            }


                        }
                        else if(oldSelectedYear < 35)
                        {


                            for (int i = model.SelectedYear; i <= 50; i++)
                            {

                                if (model.SelectedYear <= 50)
                                {
                                    double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                    double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                                    ageInMonths += 24;
                                    dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                                    endFolicularOvocites = newFolicularOvocites;

                                    if (model.SelectedYear == 50)
                                    {
                                        break;
                                    }
                                    model.SelectedYear++;
                                    model.SelectedYear++;
                                }
                                else if(model.SelectedYear > 50)
                                {
                                    double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                    double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(50, newOvo);
                                    dataValues.Add(Tuple.Create<string, double>($"50 AÑOS", newFolicularOvocites));
                                    model.SelectedYear++;
                                    endFolicularOvocites = newFolicularOvocites;

                                    break;
                                }
 

                            }
                        }
                        else
                        {
                            for (int i = model.SelectedYear; i <= 50; i++)
                            {

                                if (model.SelectedYear <= 50)
                                {
                                    double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                    double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                                    ageInMonths += 12;
                                    dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                                    endFolicularOvocites = newFolicularOvocites;

                                    if (model.SelectedYear == 50)
                                    {
                                        break;
                                    }
                                    model.SelectedYear++;
                                }
                                else if (model.SelectedYear > 50)
                                {
                                    double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                    double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(50, newOvo);
                                    dataValues.Add(Tuple.Create<string, double>($"50 AÑOS", newFolicularOvocites));
                                    model.SelectedYear++;
                                    endFolicularOvocites = newFolicularOvocites;

                                    break;
                                }


                            }
                        }

                        //if (oldSelectedYear >= 30 && oldSelectedYear < 40)
                        //{


                        //    for (int i = model.SelectedYear; i <= 50; i++)
                        //    {

                        //        if (model.SelectedYear <= 50)
                        //        {
                        //            double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                        //            double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                        //            ageInMonths += 24;
                        //            dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                        //            model.SelectedYear++;
                        //            model.SelectedYear++;
                        //        }

                        //    }
                        //}

                        
                        #endregion

                        break;

                    case 0:

                        #region escala 
                        
                        endLimitYear = oldSelectedYear + 10;

                        if(endLimitYear >= 50)
                        {
                            endLimitYear = 50;
                        }

                        //Cada dos años
                        for (int i = 0; i <= 5; i++)
                        {
                            if (model.SelectedYear < 50)
                            {
                                double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                                ageInMonths += 24;
                                dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                                endFolicularOvocites = newFolicularOvocites;
                                model.SelectedYear++;
                                model.SelectedYear++;
                            }
                            else
                            {
                                double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                                double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);

                                dataValues.Add(Tuple.Create<string, double>($"50 AÑOS", newFolicularOvocites));

                                break;
                            }



                        }

                        //Año x año
                        //for (int i = 0; i <= 10; i++)
                        //{
                        //    if (model.SelectedYear <= 50)
                        //    {
                        //        double newOvo = FertCalculator.CalculateFollicles(ageInMonths);
                        //        double newFolicularOvocites = FertCalculator.CalculateEuploidFollicles(model.SelectedYear, newOvo);
                        //        ageInMonths += 12;
                        //        dataValues.Add(Tuple.Create<string, double>($"{model.SelectedYear} AÑOS", newFolicularOvocites));
                        //        model.SelectedYear++;
                        //        endFolicularOvocites = newFolicularOvocites;

                        //    }


                        //}

                        #endregion

                        break;
                }

                //Paso a JSON la matriz de ovocitos creada arriba
                string ovoMatrixJson = JsonConvert.SerializeObject(dataValues);


                _logger.LogInformation("The fertility form was submitted succesfully");

                return RedirectToAction("Index", "Reserve", new
                {
                    OvoCount = folicularOvocites,
                    SelectedYear = oldSelectedYear,
                    QuestionUser = questionUserInt,
                    OvoMatrix = ovoMatrixJson,
                    EndOvocites = endFolicularOvocites,
                    EndAge = endLimitYear
                });
            }
            else
            {
                // Manejar el caso de error si la conversión falla
                TempData["Error"] = $"No puede elegir esa opción teniendo {questionUserInt}!";
                ModelState.AddModelError("InvalidAges", $"No puede elegir esa opción teniendo {questionUserInt}!");
                _logger.LogError("Fertility form was submitted unsuccesfully because of the current users age");

                return View("Index", model);
            }
        }




    }
}
