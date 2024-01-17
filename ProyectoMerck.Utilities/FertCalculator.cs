using ProyectoMerck.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Utilities
{
    public static class FertCalculator
    {

        public static double CalculateOvocites(int age)
        {
            double y = 319.29 * Math.Pow(age, 2) - 29392 * age + 659780;

            return y;

        }

        public static FertilityLevel FertLevelCalculator(int age)
        {

            if(age <= 30)
            {
                return FertilityLevel.High;

            }else if(age > 30 && age <= 41)
            {
                return FertilityLevel.Medium;
            }
            else
            {
                return FertilityLevel.Low;
            }

        }


    }
}
