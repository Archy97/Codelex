namespace UpperCaseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please enter a string: "); 
            string userInput = Console.ReadLine();
            var upper = userInput;

            int count = 0;
            for (int i = 0; i < upper.Length; i++)
            {
                if (char.IsUpper(upper[i])) count++;
            }

            Console.Write(count);
        }
    }
}

// Write a program that prompts the user to enter a string and displays the number of the uppercase letters in the string.