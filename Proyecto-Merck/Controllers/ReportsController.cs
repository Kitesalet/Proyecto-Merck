using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using Rotativa.AspNetCore;
using System.Data;

namespace Proyecto_Merck.Controllers
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

        public IActionResult PrintPdf(DateTime? fechaInicio, DateTime? fechaFin)
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

            List<Consultation> consultas = consultasQuery
                .Select(v => new Consultation()
                {
                    ConsultationReason = v.ConsultationReason,
                    Clinic = v.Clinic,
                    DateAndtime = v.DateAndtime,
                    Url = v.Url,
                })
                .ToList();

            return new ViewAsPdf("/Views/Reports/PrintPdf.cshtml", consultas)
            {
                FileName = "Consultas.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            };
        }


        [HttpGet]
        public async Task<FileResult> ExportPeopleToExcel(DateTime? fechaInicio, DateTime? fechaFin)
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
                    consulta.Clinic,
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
