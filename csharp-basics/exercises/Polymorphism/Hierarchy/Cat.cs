using System;
using System.Data.Common;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }

        public override void Eat(Food food)
        {
            foodEaten += food._quantity;
        }

        public override string ToString()
        {
            return $"{_animalType}[{_animalName}, {_breed}, {Math.Round(_animalWeight, 2)}, {_livingRegion}, {foodEaten}]";
        }
    }
}
