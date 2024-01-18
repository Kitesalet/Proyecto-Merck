using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.Interfaces;

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

        //[HttpPost]
        //public IActionResult AddConsultation(int model)
        //{

        //    string url = HttpContext.Request.GetDisplayUrl();

            

        //}
    }
}
