using AutoMapper;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;

namespace ProyectoMerck.Business.Services
{
    public class ClinicService : IClinicService
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;

        public ClinicService(IUnitOfWork context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }

        public async Task<List<GetClinicDto>> GetAllClinicsAsync()
        {
            
            var clinics = await _context.ClinicRepository.GetAllAsync();

            var mappedClinics = _mapper.Map<List<GetClinicDto>>(clinics);

            return mappedClinics;

        }
    }
}
