using System;

namespace PrintDayInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 7: ");
            int day = int.Parse(Console.ReadLine());
            string dayOfWeek = GetDayOfWeek(day);
            string dayOfWeek1 = GetDayOfWeek1(day);
            Console.WriteLine(dayOfWeek1);
            Console.WriteLine(dayOfWeek);
        }

        static string GetDayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Invalid day number. Please enter a number between 1 and 7.";
            }
        }

        static string GetDayOfWeek1(int day)
        {
            if (day == 1)
                return "Monday";
            else if (day == 2)
                return "Tuesday";
            else if (day == 3)
                return "Wednesday";
            else if (day == 4)
                return "Thursday";
            else if (day == 5)
                return "Friday";
            else if (day == 6)
                return "Saturday";
            else if (day == 7)
                return "Sunday";
            else
                return "Invalid day number. Please enter a number between 1 and 7.";
        }
    }
}