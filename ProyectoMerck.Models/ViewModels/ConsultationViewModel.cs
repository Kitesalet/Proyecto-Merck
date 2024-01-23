using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMerck.Models.ViewModels
{
    public class ConsultationViewModel
    {
        [Display(Name = "País")]
        [Required(ErrorMessage = "El campo País es obligatorio.")]
        public string? Country { get; set; }

        [Display(Name = "Provincia")]
        [Required(ErrorMessage = "El campo Provincia es obligatorio.")]
        public string? Province { get; set; }

        [Display(Name = "Ubicación")]
        [Required(ErrorMessage = "El campo Ubicación es obligatorio.")]
        public string? Location { get; set; }

        [Display(Name = "Motivo de Consulta")]
        [Required(ErrorMessage = "El campo Motivo de Consulta es obligatorio.")]
        public string? ReasonConsultation { get; set; }

        [Display(Name = "Clínica")]
        [Required(ErrorMessage = "El campo Clínica es obligatorio.")]
        public string? Clinic { get; set; } = null;

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string? Email { get; set; }

        [Display(Name = "Fecha y Hora")]
        [Required(ErrorMessage = "El campo Fecha y Hora es obligatorio.")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de fecha y hora no válido.")]
        public DateTime DateAndtime { get; set; }

        [Display(Name = "URL")]
        [Url(ErrorMessage = "La URL no es válida.")]
        public string? Url { get; set; } = null;



        public List<SelectListItem> Provinces { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Locations { get; set; } = new List<SelectListItem>();


    }
}
    