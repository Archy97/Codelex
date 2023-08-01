using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerChoice = Console.ReadLine().ToLower(); // Convert to lowercase
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            Console.WriteLine("Computer chose " + GetChoiceText(computerChoice));
            Console.WriteLine("User chose " + playerChoice);

            if (computerChoice == 1 && playerChoice == "rock" ||
                computerChoice == 2 && playerChoice == "paper" ||
                computerChoice == 3 && playerChoice == "scissors")
            {
                Console.WriteLine("It is a tie.");
            }
            else if (computerChoice == 1 && playerChoice == "paper" ||
                     computerChoice == 2 && playerChoice == "scissors" ||
                     computerChoice == 3 && playerChoice == "rock")
            {
                Console.WriteLine("User wins");
            }
            else
            {
                Console.WriteLine("Computer wins");
            }
        }

        static string GetChoiceText(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    return ("Invalid choice.");
            }
        }
    }
}