using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.ViewModels;

namespace Proyecto_Merck.Controllers
{
    public class ReserveController : Controller
    {
        public IActionResult Index(ReserveVM model)
        {


            return View(model);
        }
    }
}
