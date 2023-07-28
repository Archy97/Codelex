using System;

namespace TotalPay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFinalPay(7.50, 35);
            PrintFinalPay(8.20, 47);
            PrintFinalPay(10.00, 73);
        }

        static void PrintFinalPay(double basePay, int hours)
        {
            double totalPay = basePay * hours + (basePay * 1.5) * (hours - 40);

            if (basePay < 8.00) 
            {
                Console.WriteLine("Error: Base pay is below minimum wage.");
            }
            else if (hours > 60)
            {
                Console.WriteLine("Error: Hours worked exceed the maximum allowed.");
            }
            else
            {
                Console.WriteLine("Total Pay: " + totalPay);
            }
        }
    }
}