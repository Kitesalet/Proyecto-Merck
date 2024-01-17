using Microsoft.EntityFrameworkCore;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DatabaseSeeding
{
    public class ConsultationSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultation>().HasData(
                    new
                    {
                        Id = 1,
                        ConsultationReason = "Edad y Reserva Ovarica",
                        Clinic = "CEGYR Medicina Reproductiva",
                        DateAndtime = DateTime.Now,
                        Url = new Uri("https://ejemplo.com")
                    },
                    new
                    {
                        Id = 2,
                        ConsultationReason = "Evaluación de Reserva Ovárica",
                        Clinic = "Centro de Investigaciones en Medicina Reproductiva",
                        DateAndtime = DateTime.Now,
                        Url = new Uri("https://ejemplo2.com")
                    });
        }
    }
}
