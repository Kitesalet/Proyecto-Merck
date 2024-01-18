using ProyectoMerck.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.Interfaces
{
    public interface ILocationService
    {

        public Task<List<GetLocationDto>> GetLocations();

    }
}
