using System;

namespace LargestNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 =  int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(input1, input2), input3));
        }
    }
}
