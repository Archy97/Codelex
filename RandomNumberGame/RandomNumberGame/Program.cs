using System;

namespace RandomNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computerChoice = random.Next(1, 101);

            Console.Write("I'm thinking of a number between 1-100. Try to guess it: ");
            string input = Console.ReadLine();
            Console.WriteLine("> " + input + "\n");

            int userGuess;
            if (int.TryParse(input, out userGuess))
            {
                if (userGuess < computerChoice)
                {
                    Console.WriteLine("Sorry, you are too low. I was thinking of " + computerChoice + ".");
                }
                else if (userGuess > computerChoice)
                {
                    Console.WriteLine("Sorry, you are too high. I was thinking of " + computerChoice + ".");
                }

                if (userGuess == computerChoice)
                {
                    Console.WriteLine("You guessed it! What are the odds?!?");
                }
            }
        }
    }
}