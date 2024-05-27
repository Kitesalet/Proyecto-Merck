using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.Repositories
{
    public class AgePlanRepository : GenericRepository<AgePlan>, IAgePlanRepository
    {
        public AgePlanRepository(AppMerckContext context) : base(context)
        {
        }
    }
}
