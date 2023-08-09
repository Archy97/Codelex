using System;

namespace NumberSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Max? ");
            int max = int.Parse(Console.ReadLine());

            for (int row = min; row <= max; row++)
            {
                for (int column = row; column <= max; column++)
                {
                    Console.Write(column);
                }
                for (int column = min; column < row; column++)
                {
                    Console.Write(column);
                }
                Console.WriteLine();
            }
        }
    }
}
