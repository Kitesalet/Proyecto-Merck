using AutoMapper;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Utilities
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            //Province
            CreateMap<GetProvinceDto, Province>().ReverseMap();

            //Consultation
            CreateMap<GetConsultationDto, Consultation>().ReverseMap();

            //Clinic
            CreateMap<GetClinicDto, Clinic>().ReverseMap();

            //Location
            CreateMap<GetLocationDto, Location>().ReverseMap();


        }

    }
}
