using System;

namespace exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                "janka", "codelex", "automobilis", "sportisks"
            };

            Random random = new Random();

            var missedLetters = string.Empty;
            var randomWord = words[random.Next(0, words.Length)];
            var wordToDisplay = new string('*', randomWord.Length);

            while (wordToDisplay.Contains('*'))
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();
                Console.WriteLine($"Word: {wordToDisplay}");
                Console.WriteLine();
                Console.WriteLine($"Misses: {missedLetters}");
                Console.WriteLine();
                Console.Write("Guesses: ");

                var input = Console.ReadLine();
                Console.WriteLine();

                if (randomWord.Contains(input[0]))
                {
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (randomWord[i] == input[0])
                        {
                            wordToDisplay = wordToDisplay.Substring(0, i) +
                                            randomWord[i] +
                                            wordToDisplay.Substring(i + 1);
                        }
                    }
                }
                else
                {
                    missedLetters += input[0];
                }
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(randomWord);
            Console.WriteLine("YOU GOT IT!");
            Console.WriteLine("Play \"again\" or \"quit\"? quit");
        }
    }
}