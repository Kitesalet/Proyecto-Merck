using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public int? ProvinceId { get; set; }
        [Required]
        public string LocationName { get; set; } = null!;

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }
    }
}
