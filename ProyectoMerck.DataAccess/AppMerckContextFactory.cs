using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Merck.Areas.Identity.Data;

namespace ProyectoMerck.DataAccess
{

        public class AppMerckContextFactory : IDesignTimeDbContextFactory<AppMerckContext>
        {
        public AppMerckContext CreateDbContext(string[] args)
        {
                var path = Path.Combine(Directory.GetCurrentDirectory());

                string parentDirectory = Path.GetDirectoryName(path);

                string realPath = Path.Combine(parentDirectory, "MerckProject");

                Console.WriteLine(realPath);

                var configuration = new ConfigurationBuilder()
                .SetBasePath(realPath)
                .AddJsonFile("appsettings.json")
                .Build();

                var optionsBuilder = new DbContextOptionsBuilder<AppMerckContext>();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

                return new AppMerckContext(optionsBuilder.Options);
            }
        }

    
}
