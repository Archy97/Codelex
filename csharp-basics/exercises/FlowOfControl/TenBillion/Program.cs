using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TenBillion
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = int.Parse(Console.ReadLine());
            int count = 0;
            int negativeToPositive = input > 0 ? input : -input;

            while (negativeToPositive > 0)
            {
                negativeToPositive = negativeToPositive / 10;
                count++;
            }

            Console.WriteLine("Number of digits is: " + count);
        }
    }
}