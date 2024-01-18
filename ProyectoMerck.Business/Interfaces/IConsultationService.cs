using ProyectoMerck.Business.DTOs;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.Interfaces
{
    public interface IConsultationService
    {

        public Task<List<GetConsultationDto>> GetAllConsultationsAsync();


        public Task<bool> CreateConsultationAsync(ConsultationViewModel model);

    }
}
