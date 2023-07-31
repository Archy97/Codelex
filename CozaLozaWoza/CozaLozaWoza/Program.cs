using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int number = 1; number <= 110; number++)
            {
               
                counter++;

                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (number % 3 == 0 && number % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (number % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else if (number % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (number % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else
                {
                    Console.Write(number + " ");
                }

                if (counter == 11)
                {
                    Console.WriteLine();
                    counter = 0; 
                }
            }
        }
    }
}