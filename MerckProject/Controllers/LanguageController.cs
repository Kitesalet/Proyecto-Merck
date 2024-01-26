using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace MerckProject.Controllers
{
    public class LanguageController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChangeCulture(string culture)
        {

            string[] supportedCultures = ["en", "es", "pt"];

            if (supportedCultures.Contains(culture))
            {

                var newCulturecookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));

                var cookieOptions = new CookieOptions()
                {
                    Expires = DateTime.Now.AddYears(1),
                    IsEssential = true
                };

                HttpContext.Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, newCulturecookie, cookieOptions);

                return Redirect(HttpContext.Request.Headers["Referer"]);

            }

            TempData["Error"] = "Culture selected not valid";
            return RedirectToAction("Index","Home");

        }
    }
}
