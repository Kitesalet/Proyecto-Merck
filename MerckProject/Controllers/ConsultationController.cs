using AutoMapper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;

namespace MerckProject.Controllers
{
    public class ConsultationController : Controller
    {

        private readonly IConsultationService _service;
        private readonly AppMerckContext _context;
        private readonly IMapper _mapper;

        public ConsultationController(IConsultationService service, AppMerckContext context, IMapper mapper)
        {
            _context = context;
            _service = service;
            _mapper = mapper;

        }

        public async Task<IActionResult> Consultation()
        {

            ConsultationViewModel model = new ConsultationViewModel();

            model.CountryList = await _context.Countries.ToListAsync();
            model.ProvincList = await _context.Provinces.ToListAsync();
            model.ProvinceLocationList = await _context.ProvinceLocations.ToListAsync();
            var locationsDto = await _context.Locations.ToListAsync();

            model.LocationsList = locationsDto;
            model.Locations = JsonConvert.SerializeObject(locationsDto, Formatting.Indented);

            return View("Consultation", model);
        }

        //public IActionResult Consultation()
        //{
        //    var model = new ConsultationViewModel
        //    {
        //        Provinces = GetSelectListItems(
        //            items: _context.Provinces.ToList(),
        //            value: p => p.Id.ToString(),
        //            text: p => p.ProvinceName
        //        ), 

        //        Locations = GetSelectListItems(
        //            items: _context.Locations.ToList(),
        //            value: c => c.Id.ToString(),
        //            text: c => c.LocationName
        //        ),

        //        Clinics = GetSelectListItems(
        //            items: _context.Clinics.ToList(),
        //            value: c => c.Id.ToString(),
        //            text: c => c.ClinicName
        //        ),

        //        Countries = GetSelectListItems(
        //            items: _context.Countries.ToList(),
        //            value: c => c.Id.ToString(),
        //            text: c => c.CountryName
        //        ),

        //    };

        //    return View("Consultation", model);
        //}

        private List<SelectListItem> GetSelectListItems<T>(IEnumerable<T> items, Func<T, string> value, Func<T, string> text)
        {
            return items.Select(item => new SelectListItem
            {
                Value = value(item),
                Text = text(item)
            }).ToList();
        }

        //[HttpGet]
        //public IActionResult GetLocaties(string province)
        //{
        //    if (string.IsNullOrEmpty(province))
        //    {
        //        return Json(new List<SelectListItem>());
        //    }

        //    int provinceId = Convert.ToInt32(province);

        //    var locationsFiltered = _context.Locations
        //        .Where(l => l.ProvinceId == provinceId)
        //        .Select(l => new SelectListItem
        //        {
        //            Value = l.Id.ToString(),
        //            Text = l.LocationName.ToString()
        //        })
        //        .ToList();

        //    return Json(locationsFiltered);
        //}


        [HttpGet]
        public IActionResult GetClinics(string province)
        {
            if (string.IsNullOrEmpty(province))
            {
                return Json(new List<SelectList>());
            }

            var provinces = new Dictionary<string, string>
    {
            {"1", "Buenos Aires" },
            {"2", "Buenos Aires-GBA" },
            {"3", "Capital Federal" },
            {"4", "Catamarca"},
            {"5", "Chaco"},
            {"6", "Chubut"},
            {"7", "Córdoba"},
            {"8", "Corrientes"},
            {"9", "Entre Ríos"},
            {"10", "Formosa"},
            {"11", "Jujuy"},
            {"12", "La Pampa"},
            {"13", "La Rioja"},
            {"14", "Mendoza"},
            {"15", "Misiones"},
            {"16", "Neuquén"},
            {"17", "Río Negro"},
            {"18", "Salta"},
            {"19", "San Juan"},
            {"20", "San Luis"},
            {"21", "Santa Cruz"},
            {"22", "Santa Fe"},
            {"23", "Santiago del Estero"},
            {"24", "Tierra del Fuego"},
            {"25", "Tucumán"},
    };

            if (!provinces.TryGetValue(province, out var provinceName))
            {
                return Json(new List<SelectListItem>());
            }

            var leakedClinics = _context.Clinics
                .Where(c => c.ProvinceName == provinceName)
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.ClinicName
                })
                .ToList();

            return Json(leakedClinics);
        }


        [HttpPost]
        public async Task<IActionResult> AddConsultation(ConsultationViewModel model)
        {
            if (ModelState.IsValid)
            {

                model.Url = HttpContext.Request.GetDisplayUrl();

                var flag = await _service.CreateConsultationAsync(model);

                TempData["Success"] = "True";

                return RedirectToAction("Index", "Fertform");

            }
            else
            {

                //model.Provinces = GetSelectListItems(
                //items: _context.Provinces.ToList(),
                //value: p => p.Id.ToString(),
                //text: p => p.ProvinceName);


                //model.Locations = GetSelectListItems(
                //         items: _context.Locations.ToList(),
                //         value: c => c.Id.ToString(),
                //         text: c => c.LocationName
                //     );

                //model.Clinics = GetSelectListItems(
                //    items: _context.Clinics.ToList(),
                //    value: c => c.Id.ToString(),
                //    text: c => c.ClinicName
                //);

                //model.Countries = GetSelectListItems(
                //    items: _context.Countries.ToList(),
                //    value: c => c.Id.ToString(),
                //    text: c => c.CountryName
                //);

                model.CountryList = await _context.Countries.ToListAsync();
                model.ProvincList = await _context.Provinces.ToListAsync();
                model.ProvinceLocationList = await _context.ProvinceLocations.ToListAsync();
                var locationsDto = await _context.Locations.ToListAsync();

                model.LocationsList = locationsDto;
                model.Locations = JsonConvert.SerializeObject(locationsDto, Formatting.Indented);

                TempData["Error"] = "El envio del formulario no se pudo enviar correctamente";

                return View("Consultation", model);

            }





        }
    }
}
