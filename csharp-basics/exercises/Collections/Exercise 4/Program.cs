using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> namesSet = new HashSet<string>();

        string input;

        do
        {
            Console.Write("Enter name: ");
            input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                    namesSet.Add(input);
            }

        } while (!string.IsNullOrWhiteSpace(input));

        Console.WriteLine("Unique name list contains: " + string.Join(" ", namesSet));
    }
}