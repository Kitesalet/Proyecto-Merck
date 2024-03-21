using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using System.Data;

namespace MerckProject.Controllers
{
    public class ReportsController : Controller
    {

        private readonly AppMerckContext _context;
        private readonly IConsultationService _service;


        public ReportsController(AppMerckContext context, IConsultationService service)
        {
            _service = service;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Reports()
        {
            return View();
        }




        public IActionResult PrintPdf(ExportViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                TempData["Error"] = "Las fechas ingresadas son invalidas!";

                return View("Reports", model);
            }

            IQueryable<Consultation> consultasQuery = _context.Consultations;

            if(model.FechaInicio > model.FechaFin || model.FechaInicio == null || model.FechaFin == null)
            {

                TempData["Error"] = "Las fechas ingresadas son invalidas!";

                return View("Reports", model);
            }

            if (model.FechaInicio != null)
            {
                // Considerar solo la parte de la fecha
                model.FechaInicio = model.FechaInicio.Date;
                consultasQuery = consultasQuery.Where(c => c.DateAndtime.Date >= model.FechaInicio);

            }

            if (model.FechaFin != null)
            {
                // Considerar solo la parte de la fecha
                model.FechaFin = model.FechaFin.Date;
                consultasQuery = consultasQuery.Where(c => c.DateAndtime.Date <= model.FechaFin);
            }

            List<Consultation> consultas = consultasQuery
                .Select(v => new Consultation()
                {
                    ConsultationReason = v.ConsultationReason,
                    ClinicName = v.ClinicName,
                    DateAndtime = v.DateAndtime,
                    Url = v.Url,
                })
                .ToList();

            

            return new Rotativa.AspNetCore.ViewAsPdf("/Views/Reports/PrintPdf.cshtml", consultas)
            {
                FileName = "Consultas.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            };
        }


        public async Task<IActionResult> ExportPeopleToExcel(ExportViewModel model)
        {

            if (ModelState.IsValid == false)
            {
                TempData["Error"] = "Las fechas ingresadas son invalidas!";

                return View("Reports", model);
            }

            if (model.FechaInicio > model.FechaFin || model.FechaInicio == DateTime.MinValue || model.FechaFin == DateTime.MinValue)
            {

                TempData["Error"] = "Las fechas ingresadas son invalidas!";

                return View("Reports", model);
            }

            return await ExportPeopleToExcel1(model.FechaInicio, model.FechaFin);

        }

        [HttpGet]
        public async Task<FileResult> ExportPeopleToExcel1(DateTime? fechaInicio, DateTime? fechaFin)
        {
            IQueryable<Consultation> consultasQuery = _context.Consultations;

            if (fechaInicio != null)
            {
                // Considerar solo la parte de la fecha
                fechaInicio = fechaInicio?.Date;
                consultasQuery = consultasQuery.Where(c => c.DateAndtime.Date >= fechaInicio);
            }

            if (fechaFin != null)
            {
                // Considerar solo la parte de la fecha
                fechaFin = fechaFin?.Date;
                consultasQuery = consultasQuery.Where(c => c.DateAndtime.Date <= fechaFin);
            }

            var consultas = await consultasQuery.ToListAsync();
            var nombreArchivo = $"Reporte.xlsx";
            return GenerarExcel(nombreArchivo, consultas);
        }


        private FileResult GenerarExcel(string nombreArchivo, IEnumerable<Consultation> consultas)
        {

            DataTable dataTable = new DataTable("Reporte");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MotivoConsulta"),
                new DataColumn("Clinica"),
                new DataColumn("FechaYhora"),
                new DataColumn("Url")
            });

            foreach (var consulta in consultas)
            {
                dataTable.Rows.Add(
                    consulta.ConsultationReason,
                    consulta.ClinicName,
                    consulta.DateAndtime,
                    consulta.Url
                    );
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable);

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        nombreArchivo);
                }
            }
        }
    }
}
