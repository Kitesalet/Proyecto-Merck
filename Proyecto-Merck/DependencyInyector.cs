using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proyecto_Merck.Areas.Identity.Data;
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

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppMerckContext>();

            return services;

        }

    }
}
