using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.ViewModels
{
    public class FertformVM
    {
        [Required(ErrorMessage = "Año es obligatorio.")]
        [Range(1900, 2100, ErrorMessage = "Por favor ingrese un año válido.")]
        [Display(Name = "Año")]
        public int SelectedYear { get; set; }

        [Required(ErrorMessage = "Mes es obligatorio.")]
        [Range(1, 12, ErrorMessage = "Por favor ingrese un mes válido.")]
        [Display(Name = "Mes")]
        public int SelectedMonth { get; set; }

        public string? QuestionUser { get; set; }

    }

}
