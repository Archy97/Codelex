using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Orange");
            colors.Add("Purple");
            colors.Add("Black");
            colors.Add("White");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
