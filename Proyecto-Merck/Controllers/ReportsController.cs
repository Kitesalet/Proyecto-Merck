using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using Rotativa.AspNetCore;


namespace Proyecto_Merck.Controllers
{
    public class ReportsController : Controller
    {

        private readonly IConsultationService _service;


        public ReportsController(IConsultationService service)
        {
            _service = service;

        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Reports()
        {
            return View();
        }

        //public IActionResult PrintPdf(DateTime? fechaInicio, DateTime? fechaFin)
        //{

        //    //List<Consultation> consultas = consultasQuery
        //    //    .Select(v => new Consultation()
        //    //    {
        //    //        ConsultationReason = v.ConsultationReason,
        //    //        Clinic = v.Clinic,
        //    //        DateAndtime = v.DateAndtime,
        //    //        Url = v.Url,
        //    //    })
        //    //    .ToList();

        //    return new ViewAsPdf("/Views/Reports/PrintPdf.cshtml", consultas)
        //    {
        //        FileName = "Consultas.pdf",
        //        PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
        //        PageSize = Rotativa.AspNetCore.Options.Size.A4
        //    };
        }


        //[HttpGet]
        //public async Task<FileResult> ExportPeopleToExcel(DateTime? fechaInicio, DateTime? fechaFin)
        //{
            
        //    var nombreArchivo = $"Reporte.xlsx";
        //    return _services.GenerarExcel(nombreArchivo, consultas);
        //}


        
    
}
