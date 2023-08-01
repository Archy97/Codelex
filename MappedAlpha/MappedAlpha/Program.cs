using System;

namespace MappedAlpha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter: ");
            char inChar = char.ToLower(char.Parse(Console.ReadLine()));
            PhoneKeyPad(inChar);
            
        }

        static void PhoneKeyPad(char inChar)
        {
            switch (inChar)
            {
                case 'a':
                case 'b':
                case 'c':
                    Console.WriteLine("Button 2");
                    break;
                case 'd':
                case 'e':
                case 'f':
                    Console.WriteLine("Button 3");
                    break;
                case 'g':
                case 'h':
                case 'i':
                    Console.WriteLine("Button 4");
                    break;
                case 'j':
                case 'k':
                case 'l':
                    Console.WriteLine("Button 5");
                    break;
                case 'm':
                case 'n':
                case 'o':
                    Console.WriteLine("Button 6");
                    break;
                case 'p':
                case 'q':
                case 'r':
                case 's':
                    Console.WriteLine("Button 7");
                    break;
                case 't':
                case 'u':
                case 'v':
                    Console.WriteLine("Button 8");
                    break;
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    Console.WriteLine("Button 9");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid letter.");
                    break;
            }
        }
    }
}
