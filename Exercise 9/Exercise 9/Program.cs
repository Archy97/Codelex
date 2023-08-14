using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int input = int.Parse(Console.ReadLine());
            Random random = new Random();
            int sum;

            do
            {
              int  randomNumber1 = random.Next(1, 7);
              int  randomNumber2 = random.Next(1, 7);

                 sum = randomNumber1 + randomNumber2;

                Console.WriteLine($" {randomNumber1} and {randomNumber2} = {sum}");

            } while (sum != input);
        }
    } 
}
