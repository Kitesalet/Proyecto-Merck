using Microsoft.EntityFrameworkCore;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DatabaseSeeding
{
    public class ProvinceSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
            new Province { Id = 1, ProvinceName = "Buenos Aires" },
            new Province { Id = 2, ProvinceName = "Buenos Aires-GBA" },
            new Province { Id = 3, ProvinceName = "Capital Federal" },
            new Province { Id = 4, ProvinceName = "Catamarca" },
            new Province { Id = 5, ProvinceName = "Chaco" },
            new Province { Id = 6, ProvinceName = "Chubut" },
            new Province { Id = 7, ProvinceName = "Córdoba" },
            new Province { Id = 8, ProvinceName = "Corrientes" },
            new Province { Id = 9, ProvinceName = "Entre Ríos" },
            new Province { Id = 10, ProvinceName = "Formosa" },
            new Province { Id = 11, ProvinceName = "Jujuy" },
            new Province { Id = 12, ProvinceName = "La Pampa" },
            new Province { Id = 13, ProvinceName = "La Rioja" },
            new Province { Id = 14, ProvinceName = "Mendoza" },
            new Province { Id = 15, ProvinceName = "Misiones" },
            new Province { Id = 16, ProvinceName = "Neuquén" },
            new Province { Id = 17, ProvinceName = "Río Negro" },
            new Province { Id = 18, ProvinceName = "Salta" },
            new Province { Id = 19, ProvinceName = "San Juan" },
            new Province { Id = 20, ProvinceName = "San Luis" },
            new Province { Id = 21, ProvinceName = "Santa Cruz" },
            new Province { Id = 22, ProvinceName = "Santa Fe" },
            new Province { Id = 23, ProvinceName = "Santiago del Estero" },
            new Province { Id = 24, ProvinceName = "Tierra del Fuego" },
            new Province { Id = 25, ProvinceName = "Tucumán" }
        );
        }
    }
}

