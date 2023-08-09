using System;
 Loops

namespace RandomNumberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int input = int.Parse(Console.ReadLine());
            Random random = new Random();

            int sum, randomNumber1, randomNumber2;

            do
            {
                randomNumber1 = random.Next(1, 7);
                randomNumber2 = random.Next(1, 7);
                sum = randomNumber1 + randomNumber2;

                Console.WriteLine($" {randomNumber1} and  {randomNumber2} = {sum}");

            } while (sum != input);
=======
using System.Linq;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "mavis", "senaida", "letty" };
            var transformedStrings = CapMe(inputArray);
            string concatenatedResult = string.Join(Environment.NewLine, transformedStrings);
            Console.WriteLine(concatenatedResult);
        }

        static string[] CapMe(string[] input)
        {
            var transformedStrings = input.Select(str =>
                char.ToUpper(str[0]) + str.Substring(1).ToLower());

            return transformedStrings.ToArray();
 main
        }
    }
}
