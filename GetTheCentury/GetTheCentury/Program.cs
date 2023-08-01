using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            int century = GetCentury(year);
            Console.WriteLine("The year " + year + " belongs to the " + century + " century.");
        }

        public static int GetCentury(int year)
        {
            int century = (year - 1) / 100 + 1;

            return century;
        }
    }
}