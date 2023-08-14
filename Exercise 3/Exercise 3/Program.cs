using System;
using System.Collections.Generic;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                int randomNumber = rnd.Next(1, 21);
                numberList.Add(randomNumber);
            }

            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 20)
            {
                int element = numberList.ElementAt(input - 1);
                Console.WriteLine($"Element at position {input}: {element}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
