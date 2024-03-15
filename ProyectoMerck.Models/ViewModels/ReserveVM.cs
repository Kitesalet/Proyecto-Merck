using ProyectoMerck.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.ViewModels
{
    public class ReserveVM
    {
        public int SelectedYear { get; set; }
        public int SelectedMonth { get; set; }

        public int QuestionUser { get; set; }

        public double OvoCount { get; set; }
        public FertilityLevel FertilityLevel { get; set; }

    }
}
