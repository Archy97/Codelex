using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var carList = new List<Car>();
            carList.Add(new Audi());
            carList.Add(new Tesla());
            carList.Add(new Bmw());
            carList.Add(new Lexus());
            carList.Add(new Lada());
            carList.Add(new Toyota());

            Enumerable.Range(0, 10).ToList().ForEach(i =>
            {
                carList.ForEach(car =>
                {
                    if (i == 0)
                    {
                        car.StartEngine();
                    }
                    else if (i == 2 && car is IBooster boostedCar)
                    {
                        boostedCar.UseNitrousOxideEngine();
                    }
                    else
                    {
                        car.SpeedUp();
                    }
                });
            });

            Car winner = carList.First();

            foreach (var car in carList)
            {
                if (int.Parse(car.ShowCurrentSpeed()) > int.Parse(winner.ShowCurrentSpeed()))
                {
                    winner = car;
                }
            }

            Console.WriteLine($"{winner.GetType().Name} is the fastest car with a speed of {winner.ShowCurrentSpeed()} km");
        }
    }
}
