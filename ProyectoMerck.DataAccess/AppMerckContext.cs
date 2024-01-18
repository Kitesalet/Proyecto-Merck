using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoMerck.DataAccess.DatabaseSeeding;
using ProyectoMerck.Models.Entities;


namespace Proyecto_Merck.Areas.Identity.Data;

public class AppMerckContext : IdentityDbContext<IdentityUser>
{
    public AppMerckContext(DbContextOptions<AppMerckContext> options)
        : base(options)
    {
    }

    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Province> Provinces { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //var seeders = new List<IEntitySeeder>
        //    {
        //        new ConsultationSeeder(),
        //        new ClinicSeeder(),
        //        new ProvinceSeeder(),
        //        new LocationSeeder(),
        //    };
        //foreach (var seeder in seeders)
        //{
        //    seeder.SeedDataBase(builder);
        //}
        base.OnModelCreating(builder);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
