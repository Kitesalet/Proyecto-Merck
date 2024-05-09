using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoMerck.DataAccess.DatabaseSeeding;
using ProyectoMerck.Models.Entities;
using System.Reflection.Emit;


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
    public DbSet<Country> Countries { get; set; }

    public DbSet<ProvinceLocation> ProvinceLocations { get; set; }
    public object Country { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //var seeders = new List<IEntitySeeder>
        //    {
        //        new CountrySeeder(),
        //        new ConsultationSeeder(),
        //        new ClinicSeeder(),
        //        new ProvinceSeeder(),
        //        new LocationSeeder(),
        //    };
        //foreach (var seeder in seeders)
        //{
        //    seeder.SeedDataBase(builder);
        //}

        modelBuilder.Entity<Consultation>().HasData(
                new Consultation { Id = 1, ClinicName = "HIALITUS", ConsultationReason = "Stringer", SelectedLocationIndex = 2, DateAndtime = DateTime.Now, Url = "www.google.com" },
               new Consultation { Id = 2, ClinicName = "CRECER", ConsultationReason = "Inter", SelectedLocationIndex = 3, DateAndtime = new DateTime(2020,1,1), Url = "www.google.com" },
               new Consultation { Id = 3, ClinicName = "HOSPITAL ITALIANO", ConsultationReason = "Inter", SelectedLocationIndex = 4, DateAndtime = DateTime.Now, Url = "www.google.com" },
               new Consultation { Id = 4, ClinicName = "MERCK 1", ConsultationReason = "Inter", SelectedLocationIndex = 5, DateAndtime = DateTime.Now, Url = "www.google.com" },
               new Consultation { Id = 5, ClinicName = "IDERT", ConsultationReason = "Inter", SelectedLocationIndex = 6, DateAndtime = DateTime.Now, Url = "www.google.com" },
               new Consultation { Id = 6, ClinicName = "JUERTE", ConsultationReason = "Inter", SelectedLocationIndex = 7, DateAndtime = DateTime.Now, Url = "www.google.com" },
              new Consultation { Id = 7, ClinicName = "CRECER", ConsultationReason = "Inter", SelectedLocationIndex = 8, DateAndtime = DateTime.Now, Url = "www.google.com" }


        );

        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "Brasil" },
            new Country { Id = 2, Name = "Argentina" },
            new Country { Id = 3, Name = "Chile" }
        );

        modelBuilder.Entity<ProvinceLocation>().HasData(

            // Capital Federal
            new ProvinceLocation { Id = 1, Name = "Palermo", ProvinceId = 1 },
            new ProvinceLocation { Id = 2, Name = "Recoleta", ProvinceId = 1 },
            new ProvinceLocation { Id = 3, Name = "Caballito", ProvinceId = 1 },
            new ProvinceLocation { Id = 4,  Name = "Belgrano", ProvinceId = 1 }

        );

        modelBuilder.Entity<Province>().HasData(
      new Province { Id = 1, Name = "Capital Federal", CountryId = 2 }
      );

        modelBuilder.Entity<Location>().HasData(
            new Location()
            {
                Id = 1,
                Latitude = -34.600677504040895,
                Longitude = -58.387263729958455,
                Title = "Clínica Roja",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 1,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 2,
                Latitude = -34.58070285263448,
                Longitude = -58.43026097362766,
                Title = "Clínica Azul",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 1,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 3,
                Latitude = -34.578846588221204,
                Longitude = -58.46010393197798,
                Title = "Clínica Violeta",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 2,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 4,
                Latitude = -34.59925473372724,
                Longitude = -58.40181033949003,
                Title = "Clínica Verde",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 2,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 5,
                Latitude = -34.59743905645921,
                Longitude = -58.39718927947347,
                Title = "Clínica Amarilla",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 3,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 6,
                Latitude = -34.6062022234174,
                Longitude = -58.425645264604945,
                Title = "Hospital Rojo",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 3,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 7,
                Latitude = -34.596689236707874,
                Longitude = -58.39973481534347,
                Title = "Hospital Fucsia",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 4,
                Email = "mercktest111@gmail.com"
            }, new Location()
            {
                Id = 8,
                Latitude = -34.55712898207461,
                Longitude = -58.44761812883586,
                Title = "Hospital Magenta",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 4,
                Email = "mercktest111@gmail.com"
            }
            );



        base.OnModelCreating(modelBuilder);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
