﻿namespace Exercise__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var  baka = new FuelGauge();
            baka.FillUp(3);
            var meter = new Odometer(baka , 0);


            while (baka.CurrentFuelLiters > 0)
            {
                meter.IncrementMileage();
                meter.Decrement();

                Console.WriteLine($"Mileage: {meter.ReportCurrentMileage()} | Fuel: {baka.CurrentFuelLiters} liters");
            }

            Console.WriteLine("Car has run out of fuel.");
        }
    }
}
