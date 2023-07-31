using System;

namespace MoranNumber
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isHarshad =  num % CalculateSumOfDigits(num) == 0;

            if (isHarshad)
            {
                int moran = num / CalculateSumOfDigits(num);

                if (IsPrime(moran))
                {
                    Console.WriteLine("M");
                }
                else
                {
                    Console.WriteLine("H");
                }
            }

            else
            {
                Console.WriteLine("Neither");
            }
        }

        static int CalculateSumOfDigits(int number)
        {
            int sumOfDigits = 0;
            int num = number;

            while (num > 0)
            {
                sumOfDigits += num % 10;
                num /= 10;
            }

            return sumOfDigits;
        }
    }
}