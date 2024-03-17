using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.ViewModels
{
    public class FertformVM
    {

        public int SelectedYear { get; set; }
        public int SelectedMonth { get; set; }

        public DateTime SelectedDate { get;set; }

        public string? QuestionUser { get; set; }

    }

}
