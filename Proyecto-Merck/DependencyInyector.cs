using AutoMapper;
using System.Runtime.CompilerServices;

namespace Proyecto_Merck
{
    public static class DependencyInyector
    {

        public static IServiceCollection InyectServices(this IServiceCollection services)
        {
            //Automapper - Utilities
            services.AddAutoMapper(typeof(Mapper));


            return services;

        }

    }
}
