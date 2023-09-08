using System;

namespace Hierarchy
{
    internal class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zebra sound!");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("The zebra is eating.");
                foodEaten += food._quantity;
            }    
            else
            {
                Console.WriteLine($"{_animalType} are not eating that type of food!");
            }
        }
        public override string ToString()
        {
            return $"{_animalType}[{_animalName}, {Math.Round(_animalWeight, 2)}, {_livingRegion}, {foodEaten}]";
        }
    }
}
