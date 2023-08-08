using System;

class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 20, 30, 25, 35, -16, 60, -100 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                sum += numbers[i];
            }
            else if (numbers[i] < 0)
            {
                sum += Math.Abs(numbers[i]);
            }
        }

        int average = sum / numbers.Length;
        Console.WriteLine("Average value of the array elements is: " + average);
    }
}