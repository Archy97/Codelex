using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> transformedList = array.Select(value => value).ToList();
            Console.WriteLine(string.Join(", ", transformedList));

            HashSet<string> myhash1 = array.ToHashSet();

            Console.WriteLine(string.Join(", ", myhash1));

            Dictionary<string, string> myDictionary = new Dictionary<string, string>
            {
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Honda", "Japan" },
                { "Mercedes", "Germany" },
                { "VolksWagen", "Germany" },
                { "Tesla", "USA" }
            };

            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Brand: {kvp.Key}, Origination: {kvp.Value}");
            }
        }
    }
}