using System;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("RooaRRR!");
        }

        public override void Eat(Food food)

        {
            if (food is Meat)
            {
                Console.WriteLine("The tiger is eating.");
                foodEaten += food._quantity;
            }
            else if (food is Vegetable)
            {
                Console.WriteLine($"{_animalType} are not eating that type of food!");

            }
            else
            {
                Console.WriteLine("The tiger is not interested in this food.");
            }
        }

        public override string ToString()
        {
            return $"{_animalType}[{_animalName}, {Math.Round(_animalWeight, 2)}, {_livingRegion}, {foodEaten}]";
        }
    }
}
