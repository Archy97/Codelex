using System;

namespace CharCaseSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            char[] charSwappedChars = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                charSwappedChars[i] = char.IsUpper(charArray[i]) ? char.ToLower(charArray[i]) : char.ToUpper(charArray[i]);
            }

            string swappedString = new string(charSwappedChars);
            Console.WriteLine(swappedString);
        }
    }
}
