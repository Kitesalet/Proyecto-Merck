using Microsoft.AspNetCore.Mvc;

namespace MerckProject.Controllers
{
    public class LegalController : Controller
    {
        private readonly ILogger<LegalController> _logger;

        public LegalController(ILogger<LegalController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accesed Legal Index screen");


            return View();
        }

        public IActionResult Privacy()
        {

            _logger.LogInformation("Accesed Legal Privacy screen");


            return View();
        }

        public IActionResult TyC()
        {
            _logger.LogInformation("Accesed Legal TyC Screen");


            return View();
        }

        public IActionResult Disclaimer()
        {
            return View();
        }
    }
}
