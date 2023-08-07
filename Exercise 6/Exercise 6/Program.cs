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
                string output = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                                (i % 3 == 0) ? "Fizz" :
                                (i % 5 == 0) ? "Buzz" :
                                i.ToString();

                Console.Write(output + " ");

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
