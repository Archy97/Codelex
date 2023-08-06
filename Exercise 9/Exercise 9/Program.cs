using System;
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
        }
    }
}
