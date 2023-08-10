using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Enter second word");
            var input2 = Console.ReadLine();

            int remainingSpace = 30 - input1.Length - input2.Length;

            Console.Write(input1);

            for (int i = 0; i < remainingSpace; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine(input2);
        }
    }
}

