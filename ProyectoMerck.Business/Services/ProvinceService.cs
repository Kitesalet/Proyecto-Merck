

using AutoMapper;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;

namespace ProyectoMerck.Business.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;

        public ProvinceService(IUnitOfWork context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }

        public async Task<List<GetProvinceDto>> GetAllProvincesAsync()
        {
            
            var provinces = await _context.ProvinceRepository.GetAllAsync();

            var mappedProvinces = _mapper.Map<List<GetProvinceDto>>(provinces);

            return mappedProvinces;

        }
    }
}
