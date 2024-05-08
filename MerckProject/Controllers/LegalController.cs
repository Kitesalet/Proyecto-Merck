using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.ViewModels;

namespace MerckProject.Controllers
{
    public class LegalController : Controller
    {
        private readonly ILogger<LegalController> _logger;
        private readonly HttpContext _context;

        public LegalController(ILogger<LegalController> logger, IHttpContextAccessor httpContext)
        {
            _logger = logger;
            _context = httpContext.HttpContext;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accesed Legal Index screen");



            return View();
        }

        public IActionResult Privacy()
        {

            _logger.LogInformation("Accesed Legal Privacy screen");

            LegalVM model = new LegalVM();

            model.Referer = _context.Request.Headers["referer"].ToString();

            return View(model);
        }

        public IActionResult TyC()
        {
            _logger.LogInformation("Accesed Legal TyC Screen");

            LegalVM model = new LegalVM();

            model.Referer = _context.Request.Headers["referer"].ToString();

            return View(model);
        }

        public IActionResult ReturnLastPage(LegalVM model)
        {
            HttpContext context = _context;

            return Redirect(model.Referer);
        }

        public IActionResult Disclaimer()
        {
            return View();
        }
    }
}
