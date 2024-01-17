using Microsoft.EntityFrameworkCore;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DatabaseSeeding
{
    public class ClinicSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinic>().HasData(
                    new
                    {
                        Id = 1,
                        ClinicName = "CEGYR Medicina Reproductiva",
                        Address = "Viamonte 1432",
                        Latitude = -34.6007441,
                        Length = -58.3871741,
                        ProvinceName = "Capital Federal",
                        ProvinceId = 3
                    },
                    new
                    {
                        Id = 2,
                        ClinicName = "CER",
                        Address = "Humboldt 2263",
                        Latitude = -34.5806714,
                        Length = -58.4302438,
                        ProvinceName = "Catamarca",
                        ProvinceId = 4
                    },
                    new
                    {
                        Id = 3,
                        ClinicName = "Centro de Investigaciones en Medicina Reproductiva",
                        Address = "Av.Forest 1166",
                        Latitude = -34.5788222,
                        Length = -58.4600967,
                        ProvinceName = "Chaco",
                        ProvinceId = 4
                    },
                    new
                    {
                        Id = 4,
                        ClinicName = "Centro Gens",
                        Address = "Alvear 514",
                        Latitude = -34.7197709,
                        Length = -58.2562604,
                        ProvinceName = "Chubut",
                        ProvinceId = 5
                    },
                    new
                    {
                        Id = 5,
                        ClinicName = "Halitus Instituto Médico",
                        Address = "Marcelo T. de Alvear 2084",
                        Latitude = -34.5974643,
                        Length = -58.3971746,
                        ProvinceName = "Capital Federal",
                        ProvinceId = 3
                    },
                    new
                    {
                        Id = 6,
                        ClinicName = "Maternity Bank",
                        Address = "Bulnes 1104",
                        Latitude = -34.5983000,
                        Length = -58.4179000,
                        ProvinceName = "Capital Federal",
                        ProvinceId = 3
                    },
                    new
                    {
                        Id = 7,
                        ClinicName = "WeFIV",
                        Address = "Av. del Libertador 5962",
                        Latitude = -34.5571000,
                        Length = -58.4476000,
                        ProvinceName = "Capital Federal",
                        ProvinceId = 3
                    });
        }
    }
}
