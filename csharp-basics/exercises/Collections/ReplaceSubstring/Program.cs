using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var transformed = words.Select(word => word.Replace("ea", "*")).ToArray();

            Console.WriteLine(string.Join(" ", transformed));
        }
    }
}
