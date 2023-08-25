using System;
using System.Collections.Generic;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new List<string> { "Banana" });
            Smoothie s2 = new Smoothie(new List<string> { "Raspberries", "Strawberries", "Blueberries" });

            Console.WriteLine(string.Join(", ", s1.Ingredients));
            Console.WriteLine("£" + s1.GetCost().ToString("F2"));
            Console.WriteLine("£" + s1.GetPrice().ToString("F2"));
            Console.WriteLine(s1.GetName());
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", s2.Ingredients));
            Console.WriteLine("£" + s2.GetCost().ToString("F2"));
            Console.WriteLine("£" + s2.GetPrice().ToString("F2"));
            Console.WriteLine(s2.GetName());
        }
    }
}
