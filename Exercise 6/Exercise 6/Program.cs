using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max Value: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                string output;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    output = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    output = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    output = "Buzz";
                }
                else
                {
                    output = i.ToString();
                }

                Console.Write(output + " ");

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
