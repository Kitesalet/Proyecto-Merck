using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDataBase(ModelBuilder modelBuilder);
    }
}
