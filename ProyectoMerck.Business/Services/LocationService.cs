using AutoMapper;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.Services
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _context;
        private IMapper _mapper;

        public LocationService(IUnitOfWork context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }
        public async Task<List<GetLocationDto>> GetLocations()
        {

            var locations = await _context.LocationRepository.GetAllAsync();

            var locationsDto = _mapper.Map<List<GetLocationDto>>(locations);

            return locationsDto;

        }
    }
}
