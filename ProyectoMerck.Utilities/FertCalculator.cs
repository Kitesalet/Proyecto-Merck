using ProyectoMerck.Models.Enums;


namespace ProyectoMerck.Utilities
{
    public static class FertCalculator
    {

        public static double CalculateOvocites(int age)
        {
            //Formula tentativa
            //double y = 319.29 * Math.Pow(age, 2) - 29392 * age + 659780;

            Dictionary<int, double> dataValues = new Dictionary<int, double>
        {
            {18, 201359.4167}, 
            {19, 186328.0833}, 
            {20, 172180.8333}, 
            {21, 158867.8333}, 
            {22, 146342.8333}, 
            {23, 134561.75},  
            {24, 123484.0833},
            {25, 113071.3333},
            {26, 103287.5},
            {27, 94099.33333},
            {28, 85475.83333},
            {29, 77387.91667},
            {30, 69809.16667}, // 30 en adelante fertilidad media
            {31, 62715.16667},
            {32, 56083.75},
            {33, 49894.58333},
            {34, 44129.66667},
            {35, 38773.83333},
            {36, 33813.33333},
            {37, 29237.16667},
            {38, 25036.41667},
            {39, 21204.5},
            {40, 17737}, // 40 en adelante fertilidad baja
            {41, 14630.16667},
            {42, 11881.5},
            {43, 9486.333333},
            {44, 7438},
            {45, 5723.416667},
            {46, 4322.166667},
            {47, 3206.083333},
            {48, 1684},
            {49, 1600},
            {50, 1198}
        };

            if (dataValues.ContainsKey(age))
            {
                double value = dataValues[age];
                return value;
            }
            else
            {
                return 0;
            }


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
