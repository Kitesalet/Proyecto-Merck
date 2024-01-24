using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.Business.Services;
using ProyectoMerck.DataAccess;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.DataAccess.Repositories;
using System.Runtime.CompilerServices;

namespace Proyecto_Merck
{
    public static class DependencyInyector
    {

        public static IServiceCollection InyectServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Automapper - Utilities
            services.AddAutoMapper(typeof(Mapper));

            //Database Connection
            services.AddDbContext<AppMerckContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AppMerckContextConnection"));
            });
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppMerckContext>();

            //Repositories
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IConsultationRepository, ConsultationRepository>();
            services.AddScoped<IClinicRepository, ClinicRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();

            //Services
            services.AddScoped<IConsultationService, ConsultationService>();
            services.AddScoped<IProvinceService, ProvinceService>();
            services.AddScoped<IClinicService, ClinicService>();
            services.AddScoped<ILocationService, LocationService>();

            return services;

        }

    }
}
