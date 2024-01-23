

using AutoMapper;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;
using System.Data;


namespace ProyectoMerck.Business.Services
{
    public class ConsultationService : IConsultationService
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;

        public ConsultationService(IUnitOfWork context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }

        public async Task<bool> CreateConsultationAsync(ConsultationViewModel model)
        {

            bool flag = false;

            try
            {

                Uri newUri = new Uri(model.Url);

                Consultation consultation = new Consultation()
                {
                    DateAndtime = DateTime.Now,
                    Clinic = model.Clinic,
                    ConsultationReason = model.ReasonConsultation,
                    Url = newUri
                };

                flag = await _context.ConsultationRepository.Add(consultation);

                await _context.SaveChanges();

                return flag;
            }
            catch(Exception ex)
            {

                return flag;
            }
           
        }

        public async Task<List<GetConsultationDto>> GetAllConsultationsAsync()
        {
            
            var consultations = await _context.ConsultationRepository.GetAllAsync();

            var mappedConsultations = _mapper.Map<List<GetConsultationDto>>(consultations);

            return mappedConsultations;

        }

        public Task PrintPdf(DateTime? fechaInicio, DateTime? fechaFin)
        {
            throw new NotImplementedException();
        }


        public async Task<FileResult> ExportPeopleToExcel(DateTime? initionTime, DateTime? endTime)
        {
            var consulta = await _context.ConsultationRepository.GetConsultationByDate(initionTime, endTime);
            var nombreArchivo = $"Reporte.xlsx";
            return ExcelHelper.GenerarExcel(nombreArchivo, consulta);
        }

    }
}
