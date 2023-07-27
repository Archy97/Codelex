using System;

namespace ConvertMinutesToYearsAndDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of minutes: ");
            var input = Console.ReadLine();
            
            if (int.TryParse(input, out int totalMinutes))
            {
                const int MinutesInDay = 24 * 60;
                const int MinutesInYear = 365 * MinutesInDay;

                int years = totalMinutes / MinutesInYear;
                int remainingMinutes = totalMinutes % MinutesInYear;
                int days = remainingMinutes / MinutesInDay;

                Console.WriteLine($"{totalMinutes} minutes is approximately {years} years and {days} days.");
            }
                Console.ReadKey();
        }
    }
}