using System;

namespace EnergyDrinkSurvey
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            double energyDrinkers = CalculateEnergyDrinkers(NumberedSurveyed);
            double preferCitrus = CalculatePreferCitrus(energyDrinkers);

            Console.WriteLine("Total number of people surveyed: " + NumberedSurveyed);
            Console.WriteLine($"Approximately {energyDrinkers:F0} bought at least one energy drink.");
            Console.WriteLine($"Of those, {preferCitrus:F0} prefer citrus flavored energy drinks.");
        }

        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(double energyDrinkers)
        {
            return energyDrinkers * PreferCitrusDrinks;
        }
    }
}
