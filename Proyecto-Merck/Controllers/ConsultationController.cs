using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.ViewModels;

namespace Proyecto_Merck.Controllers
{
    public class ConsultationController : Controller
    {

        private readonly IConsultationService _service;
        private readonly IEmailSendeer _mailSender;


        public ConsultationController(IConsultationService service, IEmailSendeer mailSender, AppMerckContext context)
        {
            _service = service;
            _mailSender = mailSender;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Consultation()
        {

            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddConsultation(ConsultationViewModel model)
        {
            if (ModelState.IsValid)
            {
                

            model.Url = HttpContext.Request.GetDisplayUrl();

            //Hay que settear de esta forma la clínica cuando tengamos la elección acá
            model.Clinic = "Map Real Clinic Here";

            var flag = await _service.CreateConsultationAsync(model);

            var emailSubject = "Consulta";

            // Poner los datos del formulario a emailbody
            var emailBody = "Contenido";
            await _mailSender.EmailAsync(model.Email, emailSubject, emailBody);

                return RedirectToAction("Notification", model);
            }
            return View("Consultation",  model);
        }



        //private List<SelectListItem> GetSelectListItems<T>(IEnumerable<T> items, Func<T, string> valueSelector, Func<T, string> textSelector)
        //{
        //    return items.Select(item => new SelectListItem
        //    {
        //        Value = valueSelector(item),
        //        Text = textSelector(item)
        //    }).ToList();
        //}


        //[HttpGet]
        //public IActionResult ObtenerLocalidades(string provincia)
        //{
        //    if (string.IsNullOrEmpty(provincia))
        //    {
        //        return Json(new List<SelectListItem>());
        //    }
        //    int idProvincia = Convert.ToInt32(provincia);

        //    // Aquí deberías obtener las localidades filtradas por la provincia seleccionada
        //    var localidadesFiltradas = _context.Locations
        //        .Where(l => l.ProvinceId == idProvincia)
        //        .Select(l => new SelectListItem
        //        {
        //            Value = l.Id.ToString(),
        //            Text = l.LocationName.ToString()
        //        })
        //        .ToList();

        //    return Json(localidadesFiltradas);
        //}

        //[HttpGet]
        //public IActionResult ObtenerClinicas(string province)
        //{
        //    if (string.IsNullOrEmpty(province))
        //    {
        //        return Json(new List<SelectListItem>());
        //    }

        //    // Crear un diccionario de mapeo de códigos de provincia a nombres de provincia
        //    var provinces = new Dictionary<string, string>
        //        {
        //            {"1", "Buenos Aires" },
        //            {"2", "Buenos Aires-GBA" },
        //            {"3", "Capital Federal" },
        //            {"4", "Catamarca"},
        //            {"5", "Chaco"},
        //            {"6", "Chubut"},
        //            {"7", "Córdoba"},
        //            {"8", "Corrientes"},
        //            {"9", "Entre Ríos"},
        //            {"10", "Formosa"},
        //            {"11", "Jujuy"},
        //            {"12", "La Pampa"},
        //            {"13", "La Rioja"},
        //            {"14", "Mendoza"},
        //            {"15", "Misiones"},
        //            {"16", "Neuquén"},
        //            {"17", "Río Negro"},
        //            {"18", "Salta"},
        //            {"19", "San Juan"},
        //            {"20", "San Luis"},
        //            {"21", "Santa Cruz"},
        //            {"22", "Santa Fe"},
        //            {"23", "Santiago del Estero"},
        //            {"24", "Tierra del Fuego"},
        //            {"25", "Tucumán"},
        //        };

        //    // Obtener el nombre de la provincia usando el código
        //    if (provinces.TryGetValue(province, out var nameProvince))
        //    {
        //        var clinicasFiltradas = _context.Clinics
        //            .Where(c => c.ProvinceName == nameProvince)
        //            .Select(c => new SelectListItem
        //            {
        //                Value = c.Id.ToString(),
        //                Text = c.ProvinceName
        //            })
        //            .ToList();

        //        return Json(clinicasFiltradas);
        //    }
        //    else
        //    {
        //        return Json(new List<SelectListItem>());
        //    }
        //}
    }
}
