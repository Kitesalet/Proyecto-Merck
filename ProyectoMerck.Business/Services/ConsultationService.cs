

using AutoMapper;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;

namespace ProyectoMerck.Business.Services
{
    public class ConsultationService : IConsultationService
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;

        public ConsultationService(IUnitOfWork context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }

        public async Task<List<GetConsultationDto>> GetAllConsultationsAsync()
        {
            
            var consultations = await _context.ConsultationRepository.GetAllAsync();

            var mappedConsultations = _mapper.Map<List<GetConsultationDto>>(consultations);

            return mappedConsultations;

        }

        //Crear un metodo para agregar consultas en la base de datos



    }
}
