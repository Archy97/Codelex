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

            Console.WriteLine(FindNemo("I am finding Nemo !"));
            Console.WriteLine(FindNemo("Nemo is me"));
            Console.WriteLine(FindNemo("I Nemo am"));
        }

        static string FindNemo(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Nemo")
                {
                    return $"I found Nemo at {i + 1}!";
                }
            }

            return "Nemo not found :(";
        }
    }
}
