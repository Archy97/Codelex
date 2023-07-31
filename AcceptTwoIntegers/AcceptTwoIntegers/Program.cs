using System;

internal class Program
{
    static bool CheckIf15(int num1, int num2)
    {
        return (num1 == 15 || num2 == 15 || num1 + num2 == 15 || Math.Abs(num1 - num2) == 15);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        bool result = CheckIf15(num1, num2);

        Console.WriteLine("Result: " + result);
    }
}