using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.Entities
{
    public class ProvinceLocation
    {

        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Province")]
        public int ProvinceId { get; set; }

        public Province Province { get; set; }



    }
}
