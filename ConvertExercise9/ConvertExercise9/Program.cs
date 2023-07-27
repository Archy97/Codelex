using System;

namespace SpeedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters, totalTimeInSeconds, speedInMetersPerSecond, speedInKmPerHour, speedInMilesPerHour;

           
            Console.Write("Input distance in meters: ");
            if (!double.TryParse(Console.ReadLine(), out distanceInMeters))
            {
                Console.WriteLine("Invalid input. Please enter a valid distance in meters.");
                return;
            }

            Console.Write("Input hour: ");
            int hours = int.TryParse(Console.ReadLine(), out int h) ? h : 0;

            Console.Write("Input minutes: ");
            int minutes = int.TryParse(Console.ReadLine(), out int m) ? m : 0;

            Console.Write("Input seconds: ");
            int seconds = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            
            totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;
           
            speedInMetersPerSecond = distanceInMeters / totalTimeInSeconds;
     
            speedInKmPerHour = speedInMetersPerSecond * 3.6;
            speedInMilesPerHour = speedInMetersPerSecond * 2.23694;
            
            Console.WriteLine($"Your speed in meters/second is {speedInMetersPerSecond}");
            Console.WriteLine($"Your speed in km/h is {speedInKmPerHour}");
            Console.WriteLine($"Your speed in miles/h is {speedInMilesPerHour}");
           
            Console.ReadKey();
        }
    }
}