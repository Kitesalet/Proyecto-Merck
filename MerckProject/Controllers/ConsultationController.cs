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
        private readonly ILogger<ConsultationController> _logger;   

        public ConsultationController(IConsultationService service, AppMerckContext context, IMapper mapper, ILogger<ConsultationController> logger)
        {
            _context = context;
            _service = service;
            _mapper = mapper;
            _logger = logger;

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

            _logger.LogInformation("Accesed consultation screen");

            return View("Consultation", model);
        }     

        [HttpPost]
        public async Task<IActionResult> AddConsultation(ConsultationViewModel model)
        
        {
            _logger.LogInformation("Submitted the consultation formulary");

            if (ModelState.IsValid)
            {

                model.Url = HttpContext.Request.GetDisplayUrl();

                var flag = await _service.CreateConsultationAsync(model);

                TempData["Success"] = "True";

                _logger.LogInformation("A consultation was saved into the database succesfully");

                return RedirectToAction("Index", "Fertform");

            }
            else
            {

                model.CountryList = await _context.Countries.ToListAsync();
                model.ProvincList = await _context.Provinces.ToListAsync();
                model.ProvinceLocationList = await _context.ProvinceLocations.ToListAsync();
                var locationsDto = await _context.Locations.ToListAsync();
                model.SubmitError = true;

                model.LocationsList = locationsDto;
                model.Locations = JsonConvert.SerializeObject(locationsDto, Formatting.Indented);

                TempData["Error"] = "El envio del formulario no se pudo enviar correctamente";

                _logger.LogError("There has been an error sending the form");

                return View("Consultation", model);

            }





        }
    }
}
