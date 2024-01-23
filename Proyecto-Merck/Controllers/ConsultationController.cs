using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Resources;
using System.Resources;

namespace Proyecto_Merck.Controllers
{
    public class ConsultationController : Controller
    {

        private readonly IConsultationService _service;
        private readonly IEmailSendeer _mailSender;
        private readonly AppMerckContext _context;

        public ConsultationController(IConsultationService service, IEmailSendeer mailSender, AppMerckContext context)
        {
            _context = context;
            _service = service;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Consultation()
        {
            var model = new ConsultationViewModel
            {
                Provinces = GetSelectListItems(
                    items: _context.Provinces.ToList(),
                    value: p => p.Id.ToString(),
                    text: p => p.ProvinceName
                ),

                Locations = GetSelectListItems(
                    items:_context.Locations.ToList(),
                    value: c => c.Id.ToString(),
                    text: c => c.LocationName
                ),
            };

            return View("Consultation", model);
        }

        private List<SelectListItem> GetSelectListItems<T>(IEnumerable<T> items, Func<T, string> value, Func<T, string> text)
        {
            return items.Select(item => new SelectListItem
            {
                Value = value(item),
                Text = text(item)
            }).ToList();
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

            return RedirectToAction(nameof(Notification));
        }
    }
}
