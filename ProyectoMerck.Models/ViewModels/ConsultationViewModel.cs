using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMerck.Models.ViewModels
{
    public class ConsultationViewModel
    {
        [Required(ErrorMessage = "El campo País es obligatorio.")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "El campo Provincia es obligatorio.")]
        public string? Province { get; set; }

        [Required(ErrorMessage = "El campo Localidad es obligatorio.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "El campo Motivo de Consulta es obligatorio.")]
        public string? ReasonConsultation { get; set; }

        [Required(ErrorMessage = "El campo Clínica es obligatorio.")]
        public string? Clinic { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El campo Fecha y Hora es obligatorio.")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de fecha y hora no válido.")]
        public DateTime DateAndtime { get; set; }

        [Url(ErrorMessage = "La URL no es válida.")]
        public string? Url { get; set; }

        public string ClinicasItems { get; set; }
    }
}
