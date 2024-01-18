using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Models.Enums
{
    public enum FertilityLevel
    {
        [Description("Baja")]
        Low = 0,

        [Description("Media")]
        Medium = 1,

        [Description("Alta")]
        High = 2
    }
}
