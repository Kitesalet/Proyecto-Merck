using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.DTOs
{
    public class GetLocationDto
    {
        public int Id { get; set; }
        public int? ProvinceId { get; set; }
        public string LocationName { get; set; } = null!;

    }
}
