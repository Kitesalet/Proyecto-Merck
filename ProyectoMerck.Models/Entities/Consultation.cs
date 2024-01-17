using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public string Clinic { get; set; } = null!;

        public DateTime DateAndtime { get; set; }
        public Uri Url { get; set; }
    }
}
