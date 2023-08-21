using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../../midtermscores.txt";
           

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path).Split(" ");

            var range = new SortedDictionary<int, string>();
            for (var i = 0; i <= 100; i += 10)
            {
                range.Add(i, "");
            }

            foreach (var c in readText)
            {
                var number = Convert.ToInt32(c);

                for (int key = 0; key <= 100; key += 10)
                {
                    int maxIndex = key + 9;

                    if (number >= key && number < maxIndex)
                    {
                        range[key] += "*";
                    }
                }
            }

            foreach (var kvp in range)
            {
                var formattedKey = kvp.Key < 100 ? $"{kvp.Key:D2}-{kvp.Key + 9:D2}" : $"  {kvp.Key}";
                Console.WriteLine($"{formattedKey}: {kvp.Value}");
            }
        }
    }
}