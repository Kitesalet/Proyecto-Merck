using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DTOs
{
    public class GetConsultationDto
    {
        public int Id { get; set; }
        public string ConsultationReason { get; set; } = null!;
        public string Clinic { get; set; } = null!;
        public DateTime DateAndtime { get; set; }
        public Uri Url { get; set; }

    }
}
