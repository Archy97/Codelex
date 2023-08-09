using System;

 Loops
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
=======
namespace CountPositiveAndSumNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            CountAndSum(numbers);
        }

        static void CountAndSum(int[] array)
        {
            int positiveCount = 0;
            int sumNegatives = 0;

            foreach (int number in array)
            {
                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    sumNegatives += number;
                }
            }

            Console.WriteLine(positiveCount == 0 ? "[]" : $"{positiveCount} {sumNegatives}");
 main
        }
    }
}
