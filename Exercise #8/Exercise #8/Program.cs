using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int totalLength = input * 4 - 4;

            for (int i = 0; i < input; i++)
            {
                int strLength = i * 4;
                int spaceLength = totalLength - strLength;

                Console.WriteLine(new string('/', spaceLength) + new string('*', strLength)
                                                               + new string('*', strLength) + new string('\\', spaceLength));
            }
        }
    }
}