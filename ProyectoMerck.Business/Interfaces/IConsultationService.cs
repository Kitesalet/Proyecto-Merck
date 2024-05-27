using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.Interfaces
{
    public interface IAgePlanService
    {

        public Task<List<AgePlan>> GetAllConsultationsAsync();


        public Task<bool> CreateConsultationAsync(FertformVM model);



        //public Task PrintPdf(DateTime? fechaInicio, DateTime? fechaFin);

        //public Task<FileResult> ExportPeopleToExcel(DateTime? fechaInicio, DateTime? fechaFin);


    }
}
