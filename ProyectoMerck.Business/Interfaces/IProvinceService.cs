using ProyectoMerck.Business.DTOs;
using ProyectoMerck.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.Interfaces
{
    public interface IProvinceService
    {

        public Task<List<GetProvinceDto>> GetAllProvincesAsync();

    }
}
