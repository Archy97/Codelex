using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerChoice = Console.ReadLine();
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            switch (computerChoice)
            {
                case 1: 
                    Console.WriteLine("Computer chose Rock");

                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("It is a tie.");
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("User wins");
                    }
                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer wins");
                    }
                    break;

                case 2: 
                    Console.WriteLine("Computer chose Paper");

                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer wins");
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("It is a tie.");
                    }
                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("User wins");
                    }
                    break;

                case 3: 
                    Console.WriteLine("Computer chose Scissors");

                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("User wins.");
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer wins");
                    }
                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("It is a tie.");
                    }
                    break;
            }
        }
    }
}
