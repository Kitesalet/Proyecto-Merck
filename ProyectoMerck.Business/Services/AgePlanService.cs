using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.Services
{
    public class AgePlanService : IAgePlanService
    {
        private readonly IUnitOfWork _context;

        public AgePlanService(IUnitOfWork context)
        {
            _context = context;
        }
        public async Task<bool> CreateConsultationAsync(FertformVM model)
        {
            AgePlan plan = new AgePlan();

            plan.Age = model.SelectedYear;
            plan.PlannedAge = model.QuestionUser;
            plan.DateAndtime = DateTime.Now;

            await _context.AgePlanRepository.Add(plan);

            await _context.SaveChanges();

            return true;

        }

        public async Task<List<AgePlan>> GetAllConsultationsAsync()
        {
            return (List<AgePlan>)await _context.AgePlanRepository.GetAllAsync();
        }
    }
}
