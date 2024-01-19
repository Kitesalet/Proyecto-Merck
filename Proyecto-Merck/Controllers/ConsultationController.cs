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
        private readonly IEmailSendeer _mailSender;

        public ConsultationController(IConsultationService service, IEmailSendeer mailSender)
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

            model.Url = HttpContext.Request.GetDisplayUrl();

            //Hay que settear de esta forma la clínica cuando tengamos la elección acá
            model.Clinic = "Map Real Clinic Here";

            var flag = await _service.CreateConsultationAsync(model);

            var emailSubject = "Consulta";
            var emailBody = "Contenido";
            await _mailSender.EmailAsync(model.Email, emailSubject, emailBody);

            return RedirectToAction(nameof(Notification));
        }
    }
}
