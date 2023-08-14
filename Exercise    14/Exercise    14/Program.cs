using System;
using System.Globalization;

namespace Exercise____14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = new CultureInfo("nl-NL");

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            string weekdayName = WeekdayInDutch(year, month, day, culture);

            Console.WriteLine($"Weekday name in Dutch: {weekdayName}");
        }

        public static string WeekdayInDutch(int year, int month, int day, CultureInfo culture)
        {
            DateTime date = new DateTime(year, month, day);
            string weekdayName = date.ToString("dddd", culture);

            return weekdayName;
        }
    }
}