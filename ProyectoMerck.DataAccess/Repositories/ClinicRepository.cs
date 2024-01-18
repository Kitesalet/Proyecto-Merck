using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;

namespace ProyectoMerck.DataAccess.Repositories
{
    public class ClinicRepository : GenericRepository<Clinic>, IClinicRepository
    {
        public ClinicRepository(AppMerckContext context) : base(context)
        {
        }


    }
}
