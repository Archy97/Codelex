using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Welcome to Piglet!");
            int sum = 0;

            while (sum != 1)
            {
                int diceRoll = random.Next(1, 7);
                sum += diceRoll;
                Console.WriteLine($"You Rolled {diceRoll}");

                if (diceRoll == 1)
                {
                    Console.WriteLine("You got 0 points");
                    break;
                }
                else
                {
                    Console.Write("Roll again? (yes/no): ");
                    string response = Console.ReadLine();

                    if (response.ToLower() != "yes")
                    {
                        Console.WriteLine($"You got {sum} points!");
                        break;
                    }
                }
            }
        }
    }
}
