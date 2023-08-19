using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(55);
            Car car2 = new Car(70);

            car1.FillUp(700, 100);
            Console.WriteLine("Car 1 first fill-up consumption: " + car1.CalculateConsumption());

            car1.FillUp(1000, 60);
            Console.WriteLine("Car 1 second fill-up consumption: " + car1.CalculateConsumption());

            car2.FillUp(900, 80);
            Console.WriteLine("Car 2 first fill-up consumption: " + car2.CalculateConsumption());

            if (car1.IsGasHog())
            {
                Console.WriteLine("Car 1 is a gas hog");
            }
            else
            {
                Console.WriteLine("Car 1 is not a gas hog");
            }

            if (car2.IsEconomyCar())
            {
                Console.WriteLine("Car 2 is an economy car");
            }
            else
            {
                Console.WriteLine("Car 2 is not an economy car");
            }
        }
    }
}
