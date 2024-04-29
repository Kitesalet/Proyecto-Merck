using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.Business.DTOs;
using ProyectoMerck.Business.Interfaces;
using ProyectoMerck.DataAccess.DTOs;
using ProyectoMerck.DataAccess.Interfaces;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Models.ViewModels;
using ProyectoMerck.Utilities;
using System.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Abstractions;
using Microsoft.EntityFrameworkCore;
using ProyectoMerck.Resources;

namespace ProyectoMerck.Business.Services
{
    public class ConsultationService : IConsultationService
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly IEmailSendeer _mailSender;
        private readonly AppMerckContext _dbContext;

        public ConsultationService(IUnitOfWork context, IMapper mapper, IEmailSendeer mailSender, AppMerckContext dbContext)
        {
            _dbContext = dbContext;
            _context = context;
            _mapper = mapper;
            _mailSender = mailSender;

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
                    SelectedLocationIndex = model.SelectedLocationIndex,
                    ConsultationReason = model.ReasonConsultation,
                    Url = model.Url
                };

                Location clinic = await _dbContext.Locations
                                                    .Where(c => c.Id == model.SelectedLocationIndex)
                                                    .FirstOrDefaultAsync();

                consultation.ClinicName = clinic.Title;
                

                flag = await _context.ConsultationRepository.Add(consultation);

                await _context.SaveChanges();

                //Envia el email
                ResourceManager manager = new ResourceManager("ProyectoMerck.Resources.ConsultationResources", typeof(ConsultationResources).Assembly);

                var emailSubject = manager.GetString("EmailSubject");
                var emailBody = manager.GetString("EmailBody");

                var emailSubjectFormatted = String.Format(emailSubject, new Random().Next(1, 9999999));
                var emailBodyFormatted = String.Format(emailBody, clinic.Title, model.Email, model.TelephoneNumber, model.FullName, model.ReasonConsultation);

                await _mailSender.EmailAsync(clinic.Email, emailSubjectFormatted, emailBodyFormatted);

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

    }
}
