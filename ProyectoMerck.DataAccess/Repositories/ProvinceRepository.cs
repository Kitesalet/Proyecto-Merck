using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;

namespace ProyectoMerck.DataAccess.Repositories
{
    public class ProvinceRepository : GenericRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(AppMerckContext context) : base(context)
        {
        }


    }
}
