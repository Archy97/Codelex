using System;

class Program
{
    static void Main(string[] args)
    {
        int i, n, baseNumber;

        Console.WriteLine("Input base number: ");
        baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input exponent: ");
        n = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (i = 0; i < n; i++)
        {
            result *= baseNumber;
        }

        Console.WriteLine($"Result of {baseNumber} raised to the power of {n} is: {result}");

        Console.ReadKey();
    }
}
