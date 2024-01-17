using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.Entities
{
    public class Province
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProvinceName { get; set; } = null!;

        public virtual ICollection<Location> Localities { get; set; } = new List<Location>();
    }
}
