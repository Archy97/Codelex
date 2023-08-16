using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> color = new List<string>();

            color.Add("Red");
            color.Add("Orange");
            color.Add("Purple");
            color.Add("Black");
            color.Add("White");

            foreach (string c in color)
            {
                Console.WriteLine(c);
            }
        }
    }
}
