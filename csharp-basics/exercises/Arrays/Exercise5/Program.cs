using System;

class Program
{
    static int IndexOf(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int[] myArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };

        int input = int.Parse(Console.ReadLine());

        int index = IndexOf(myArray, input);

        Console.WriteLine("Index position of " + input + " in array is " + index);
    }
}