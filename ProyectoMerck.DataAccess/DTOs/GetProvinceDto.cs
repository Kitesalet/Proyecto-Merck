using ProyectoMerck.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DTOs
{
    public class GetProvinceDto
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; } = null!;
        public virtual ICollection<Location> Localities { get; set; } = new List<Location>();

    }
}
