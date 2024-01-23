using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.Interfaces
{
    public interface IConsultationRepository
    {
        public Task<List<Consultation>> GetConsultationByDate(DateTime? initialTime, DateTime? endtime);
    }
}
