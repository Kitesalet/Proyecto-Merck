using Microsoft.EntityFrameworkCore;
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
    public class ConsultationRepository : GenericRepository<Consultation>, IConsultationRepository
    {
        private readonly AppMerckContext _context;

        public ConsultationRepository(AppMerckContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Consultation>> GetConsultationByDate(DateTime? initialTime, DateTime? endtime)
        {
            IQueryable<Consultation> consultasQuery = _context.Consultations;

            if (initialTime != null)
            {
                // Considerar solo la parte de la fecha
                initialTime = initialTime?.Date;
                consultasQuery = consultasQuery.Where(c => c.DateAndtime.Date >= initialTime);
            }

            if (endtime != null)
            {
                // Considerar solo la parte de la fecha
                endtime = endtime?.Date;
                consultasQuery = consultasQuery.Where(c => c.DateAndtime.Date <= endtime);
            }

            var consultas = await consultasQuery.ToListAsync();

            return consultas;   
        }
    }
}
