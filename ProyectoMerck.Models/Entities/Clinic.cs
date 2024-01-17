using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.Entities
{
    public class Clinic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClinicName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Length { get; set; }

        [Required]
        public string ProvinceName { get; set; }
        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }
    }
}
