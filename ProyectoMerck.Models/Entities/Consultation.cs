using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.Entities
{
    public class Consultation
    {
        [Key]
        public int Id { get; set; }
        public string ConsultationReason { get; set; } = null!;

        [ForeignKey("Location")]
        public int SelectedLocationIndex { get; set; }

        public string? ClinicName { get; set; }
        public DateTime DateAndtime { get; set; } 
        public string? Url { get; set; }
    }
}
