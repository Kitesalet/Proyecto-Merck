using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Business.DTOs
{
    public class GetClinicDto
    {
        public int Id { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Length { get; set; }
        public string ProvinceName { get; set; }
        public int ProvinceId { get; set; }

    }
}
