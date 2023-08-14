using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input base number: ");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input exponent: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 0; i < n; i++)
        {
            result *= baseNumber;
        }

        Console.WriteLine($"Result of {baseNumber} raised to the power of {n} is: {result}");

        Console.ReadKey();
    }
}
