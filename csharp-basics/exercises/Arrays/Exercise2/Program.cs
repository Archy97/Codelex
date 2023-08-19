using System;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int max = int.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
