using Microsoft.EntityFrameworkCore;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DatabaseSeeding
{
    public class CountrySeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                    new
                    {
                        Id = 1,
                        CountryName = "Argentina"
                    });
        }
    }
}
