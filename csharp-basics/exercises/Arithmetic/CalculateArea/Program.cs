﻿using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var userChoice = 0;

            while (userChoice != 4)
            {
                userChoice = GetMenu(); 

                switch (userChoice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    
                    default:
                        Console.WriteLine(" Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }
            }
        }

        public static int GetMenu()
        {
            
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            int userChoice = int.Parse(keyboard.KeyChar.ToString());

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            
            Console.WriteLine("What is the circle's radius? ");
            var radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine(" Enter length? ");
            var length =decimal.Parse(Console.ReadLine());

            Console.WriteLine(" Enter width? ");
            var width =decimal.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine(" Enter length of the triangle's base? ");
            var ground = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" Enter triangle's height? ");
            var height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
