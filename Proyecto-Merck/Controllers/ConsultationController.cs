using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.ViewModels;

namespace Proyecto_Merck.Controllers
{
    public class ConsultationController : Controller
    {

        private readonly IConsultationService _service;

        public ConsultationController(IConsultationService service)
        {

            _service = service;

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

            model.Url = HttpContext.Request.GetDisplayUrl();

            //Hay que settear de esta forma la clínica cuando tengamos la elección acá
            model.Clinic = "Map Real Clinic Here";

            var flag = await _service.CreateConsultationAsync(model);

            return RedirectToAction(nameof(Notification));
        }
    }
}
