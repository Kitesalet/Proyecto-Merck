using ProyectoMerck.Models.Enums;

namespace ProyectoMerck.Utilities
{
    public static class FertCalculator
    {

        public static double CalculateFollicles(int months)
        {
            double a = 0.0595;     // Parámetro 'a'
            double b = 3716;       // Parámetro 'b'
            double c = 11780;      // Parámetro 'c'
            double N0 = 701200;    // Condición inicial N(0)
            double t0 = 0;         // Tiempo inicial
            double t_final = months / 12.0; // Tiempo final (convertir meses a años)
            double h = 1.0 / 12.0; // Tamaño del paso (un mes en años)

            double N = N0;
            double t = t0;

            while (t < t_final)
            {
                double k1 = h * dNdt(t, N, a, b, c);
                double k2 = h * dNdt(t + h / 2, N + k1 / 2, a, b, c);
                double k3 = h * dNdt(t + h / 2, N + k2 / 2, a, b, c);
                double k4 = h * dNdt(t + h, N + k3, a, b, c);

                N = N + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                N = Math.Round(N); // Redondear N a un número entero
                t = t + h;
            }

            return Math.Round(N);
        }

        static double dNdt(double t, double N, double a, double b, double c)
        {
            return -N * (a + b / (c + N));
        }

        public static double CalculateEuploidFollicles(double ageYears, double follicleCount)
        {
            if (ageYears < 30)
                return Math.Round(follicleCount * 0.677);
            else if (ageYears < 35)
                return Math.Round(follicleCount * 0.6);
            else if (ageYears < 38)
                return Math.Round(follicleCount * 0.556);
            else if (ageYears < 41)
                return Math.Round(follicleCount * 0.504);
            else if (ageYears < 61)
                return Math.Round(follicleCount * 0.299);
            else
                return Math.Round(follicleCount); // Default value if age is 61 or higher
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
