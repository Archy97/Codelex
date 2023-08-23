using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>(); 

            Animal animal = null;
            Food food = null;

            string animalInfo;
            while ((animalInfo = Console.ReadLine()) != "End")
            {
                string[] animalTokens = animalInfo.Split();
                string animalType = animalTokens[0];
                string animalName = animalTokens[1];
                double animalWeight = double.Parse(animalTokens[2]);
                string livingRegion = animalTokens[3];
                string breed = null;

                if (animalType == "Cat")
                {
                    breed = animalTokens[4];
                }

                switch (animalType)
                {
                    case "Cat":
                        animal = new Cat(animalType, animalName, animalWeight, livingRegion, breed);
                        break;
                    case "Tiger":
                        animal = new Tiger(animalType, animalName, animalWeight, livingRegion);
                        break;
                }

                animal.MakeSound();

                string foodInfo = Console.ReadLine();
                string[] foodTokens = foodInfo.Split();
                string foodType = foodTokens[0];
                int quantity = int.Parse(foodTokens[1]);

                switch (foodType)
                {
                    case "Vegetable":
                        food = new Vegetable(quantity);
                        break;
                    case "Meat":
                        food = new Meat(quantity);
                        break;
                }

                if (food != null)
                {
                    animal.Eat(food);
                    if (animalType == "Cat")
                    {
                        Console.WriteLine($"{animalType}, {animalName}, {animalWeight:F1}, {livingRegion}, {breed} {quantity}");
                    }
                }
                else if (animalType == "Tiger")
                {
                    animal.Eat(food);
                }

                animals.Add(animal);
                
            }

            foreach (Animal a in animals)
            {
                Console.Write(a);
            }
        }
    }
}
