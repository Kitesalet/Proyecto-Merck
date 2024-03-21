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
            // Buenos Aires
            new ProvinceLocation { Id = 1, Name = "Magdalena", ProvinceId = 1 },
            new ProvinceLocation { Id = 2, Name = "La Plata", ProvinceId = 1 },

            // Buenos Aires-GBA
            new ProvinceLocation { Id = 3, Name = "Quilmes", ProvinceId = 2 },
            new ProvinceLocation { Id = 4, Name = "Avellaneda", ProvinceId = 2 },

            // Capital Federal
            new ProvinceLocation { Id = 5, Name = "Palermo", ProvinceId = 3 },
            new ProvinceLocation { Id = 6, Name = "Recoleta", ProvinceId = 3 },

            // Catamarca
            new ProvinceLocation { Id = 7, Name = "Oasis del Desierto", ProvinceId = 4 },
            new ProvinceLocation { Id = 8, Name = "Pico de la Luna", ProvinceId = 4 },

            // Chaco
            new ProvinceLocation { Id = 9, Name = "Selva Esmeralda", ProvinceId = 5 },
            new ProvinceLocation { Id = 10, Name = "Río Dorado", ProvinceId = 5 },

            // Chubut
            new ProvinceLocation { Id = 11, Name = "Costa Azul", ProvinceId = 6 },
            new ProvinceLocation { Id = 12, Name = "Bosque Mágico", ProvinceId = 6 },

            // Córdoba
            new ProvinceLocation { Id = 13, Name = "Sierras Doradas", ProvinceId = 7 },
            new ProvinceLocation { Id = 14, Name = "Valle de los Suspiros", ProvinceId = 7 },

            // Corrientes
            new ProvinceLocation { Id = 15, Name = "Río Paraná", ProvinceId = 8 },
            new ProvinceLocation { Id = 16, Name = "Bosque Encantado", ProvinceId = 8 },

            // Entre Ríos
            new ProvinceLocation { Id = 17, Name = "Termas del Guaychú", ProvinceId = 9 },
            new ProvinceLocation { Id = 18, Name = "Puerto de las Palmas", ProvinceId = 9 },

            // Formosa
            new ProvinceLocation { Id = 19, Name = "Lago Formosa", ProvinceId = 10 },
            new ProvinceLocation { Id = 20, Name = "Pueblo de las Aves", ProvinceId = 10 },

            // Jujuy
            new ProvinceLocation { Id = 21, Name = "Valle de los Colores", ProvinceId = 11 },
            new ProvinceLocation { Id = 22, Name = "Cerro de Siete Colores", ProvinceId = 11 },

            // La Pampa
            new ProvinceLocation { Id = 23, Name = "Pampa Dorada", ProvinceId = 12 },
            new ProvinceLocation { Id = 24, Name = "Laguna Escondida", ProvinceId = 12 },

            // La Rioja
            new ProvinceLocation { Id = 25, Name = "Valle de la Luna", ProvinceId = 13 },
            new ProvinceLocation { Id = 26, Name = "Cascada del Cielo", ProvinceId = 13 },

            // Mendoza
            new ProvinceLocation { Id = 27, Name = "Viñedos del Sol", ProvinceId = 14 },
            new ProvinceLocation { Id = 28, Name = "Cerro Aconcagua", ProvinceId = 14 },

            // Misiones
            new ProvinceLocation { Id = 29, Name = "Cataratas del Iguazú", ProvinceId = 15 },
            new ProvinceLocation { Id = 30, Name = "Bosque Misionero", ProvinceId = 15 },

            // Neuquén
            new ProvinceLocation { Id = 31, Name = "Lago Nahuel Huapi", ProvinceId = 16 },
            new ProvinceLocation { Id = 32, Name = "Cerro Chapelco", ProvinceId = 16 }
        );

        modelBuilder.Entity<Province>().HasData(
      new Province { Id = 1, Name = "Buenos Aires", CountryId = 2 },
      new Province { Id = 2, Name = "Buenos Aires-GBA", CountryId = 2 },
      new Province { Id = 3, Name = "Capital Federal", CountryId = 2 },
      new Province { Id = 4, Name = "Catamarca", CountryId = 2 },
      new Province { Id = 5, Name = "Chaco", CountryId = 2 },
      new Province { Id = 6, Name = "Chubut", CountryId = 2 },
      new Province { Id = 7, Name = "Córdoba", CountryId = 2 },
      new Province { Id = 8, Name = "Corrientes", CountryId = 2 },
      new Province { Id = 9, Name = "Entre Ríos", CountryId = 2 },
      new Province { Id = 10, Name = "Formosa", CountryId = 2 },
      new Province { Id = 11, Name = "Jujuy", CountryId = 2 },
      new Province { Id = 12, Name = "La Pampa", CountryId = 2 },
      new Province { Id = 13, Name = "La Rioja", CountryId = 2 },
      new Province { Id = 14, Name = "Mendoza", CountryId = 2 },
      new Province { Id = 15, Name = "Misiones", CountryId = 2 },
      new Province { Id = 16, Name = "Neuquén", CountryId = 2 },
      new Province { Id = 17, Name = "Río Negro", CountryId = 2 },
      new Province { Id = 18, Name = "Salta", CountryId = 2 },
      new Province { Id = 19, Name = "San Juan", CountryId = 2 },
      new Province { Id = 20, Name = "San Luis", CountryId = 2 },
      new Province { Id = 21, Name = "Santa Cruz", CountryId = 2 },
      new Province { Id = 22, Name = "Santa Fe", CountryId = 2 },
      new Province { Id = 23, Name = "Santiago del Estero", CountryId = 2 },
      new Province { Id = 24, Name = "Tierra del Fuego", CountryId = 2 },
      new Province { Id = 25, Name = "Tucumán", CountryId = 2 }
        );


        modelBuilder.Entity<Location>().HasData(
            new Location()
            {
                Id = 1,
                Latitude = -34.600677504040895,
                Longitude = -58.387263729958455,
                Title = "CEGYR",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 1
            }, new Location()
            {
                Id = 2,
                Latitude = -34.58070285263448,
                Longitude = -58.43026097362766,
                Title = "CER",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 2
            }, new Location()
            {
                Id = 3,
                Latitude = -34.578846588221204,
                Longitude = -58.46010393197798,
                Title = "CIMER",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 3
            }, new Location()
            {
                Id = 4,
                Latitude = -34.59925473372724,
                Longitude = -58.40181033949003,
                Title = "CRECER",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 4
            }, new Location()
            {
                Id = 5,
                Latitude = -34.59743905645921,
                Longitude = -58.39718927947347,
                Title = "HIALITUS",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 5
            }, new Location()
            {
                Id = 6,
                Latitude = -34.6062022234174,
                Longitude = -58.425645264604945,
                Title = "HOSPITAL ITALIANO",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 5
            }, new Location()
            {
                Id = 7,
                Latitude = -34.596689236707874,
                Longitude = -58.39973481534347,
                Title = "IFER",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 4
            }, new Location()
            {
                Id = 8,
                Latitude = -34.55712898207461,
                Longitude = -58.44761812883586,
                Title = "WEFIV",
                Subtitle = "Centro Fertilidad",
                ProvinceLocationId = 3
            }
            );



        base.OnModelCreating(modelBuilder);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
