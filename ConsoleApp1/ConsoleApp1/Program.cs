using System;

namespace exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = new int[10];
            Random rand = new Random();

            for (int i = 0; i < intArray1.Length; i++)
            {
                intArray1[i] = rand.Next(1, 101);
            }

            int[] intArray2 = new int[intArray1.Length];
            Array.Copy(intArray1, intArray2, intArray1.Length);

            intArray1[intArray1.Length - 1] = -7;

            Console.WriteLine("Source Array: " + string.Join(", ", intArray1));
            Console.WriteLine("Copied Array: " + string.Join(", ", intArray2));
        }
    }
}