using System;
using System.IO;
using System.Linq;

namespace Exercise
{
    class Program
    {
        public long CountWords(FileInfo file)
        {
            string content = File.ReadAllText(file.FullName);
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r', '\'' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public long CountLetters(FileInfo file)
        {
            string content = File.ReadAllText(file.FullName);
            char[] charsToRemove = { ',', '.', '\'' };

            string cleanedText = new string(content.Where(c => !charsToRemove.Contains(c)).ToArray());

            return cleanedText.Length;
        }

        public long CountLinesLINQ(FileInfo file) =>
            File.ReadLines(file.FullName).Count();

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\uniku\source\repos\Codelex5\csharp-basics\exercises\Collections\WordCount\lear.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            Program program = new Program();
            long lineCount = program.CountLinesLINQ(fileInfo);
            long wordCount = program.CountWords(fileInfo);
            long letterCount = program.CountLetters(fileInfo);

            Console.WriteLine($"Number of words in the file: {wordCount}");
            Console.WriteLine($"Number of lines in the file: {lineCount}");
            Console.WriteLine($"Number of letters in the file: {letterCount}");
        }
    }
}