using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>()
        {
            1789, 2035, 1899, 1456, 2013,
            1458, 2458, 1254, 1472, 2365,
            1456, 2265, 1457, 2456
        };

        Console.Write("Enter a number to check: ");
        int inputNumber = int.Parse(Console.ReadLine());

        if (numbers.Contains(inputNumber))
        {
            Console.WriteLine("Contains");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}
