﻿using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int aInt = int.Parse(a); 
            double sum = aInt + b + c + d + e;

            Console.WriteLine(sum);
        }

        static void Second()
        {
           
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            int aInt = int.Parse(a);
            double sum = aInt + b + c + d + e;

            Console.WriteLine(sum.ToString("F1"));
        }
    }
}