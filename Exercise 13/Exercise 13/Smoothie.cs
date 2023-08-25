using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_13
{
    public class Smoothie
    {
        public List<string> Ingredients { get; private set; }

        public Smoothie(List<string> ingredients)
        {
            Ingredients = ingredients;
        }

        public double GetCost()
        {
            double totalCost = 0;

            foreach (string ingredient in Ingredients)
            {
                switch (ingredient)
                {
                    case "Strawberries":
                        totalCost += 1.50;
                        break;
                    case "Banana":
                        totalCost += 0.50;
                        break;
                    case "Mango":
                        totalCost += 2.50;
                        break;
                    case "Blueberries":
                        totalCost += 1.00;
                        break;
                    case "Raspberries":
                        totalCost += 1.00;
                        break;
                    case "Apple":
                        totalCost += 1.75;
                        break;
                    case "Pineapple":
                        totalCost += 3.50;
                        break;
                }
            }

            return totalCost;
        }

        public double GetPrice()
        {
            double cost = GetCost();
            double price = cost + (cost * 1.5);
            return Math.Round(price, 2);
        }

        public string GetName()
        {
            List<string> sortedIngredients = Ingredients.OrderBy(ingredient => ingredient).ToList();

            var name = "";
            foreach (string ingredient in sortedIngredients)
            {
                if (ingredient.EndsWith("berries"))
                {
                    name += ingredient.Replace("berries", "berry") + " ";
                }
                else
                {
                    name += ingredient + " ";
                }
            }

            if (sortedIngredients.Count < 2)
            {
                return $"Delicious {name}Smoothie";
            }
            else
            {
                return $"Delicious {name}Fusion";
            }
        }
    }
}
