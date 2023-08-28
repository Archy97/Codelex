using System;
using System.Collections.Generic;

namespace Exercise_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHashSet = new HashSet<string>();

            myHashSet.Add("Value 1");
            myHashSet.Add("Value 2");
            myHashSet.Add("Value 3");
            myHashSet.Add("Value 4");
            myHashSet.Add("Value 5");

            Console.WriteLine(string.Join(" " ,myHashSet));

            myHashSet.Clear();

            myHashSet.Add("Value 1");
            myHashSet.Add("Value 1");

            Console.WriteLine(string.Join(" ", myHashSet));
        }
    }
}