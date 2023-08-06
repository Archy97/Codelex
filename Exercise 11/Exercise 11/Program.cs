using System;

namespace FindNemoExample
{
    class Program
    {
        static void Main(string[] args)
        {
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