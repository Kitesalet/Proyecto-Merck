using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Utilities
{
    public static class ExcelHelper
    {
        public static FileResult GenerarExcel(string nombreArchivo, IEnumerable<Consultation> consultas)
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
