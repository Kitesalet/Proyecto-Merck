using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Merck.Controllers
{
    public class ConsultationController : Controller
    {
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
    }
}
