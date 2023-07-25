using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, eyes, teeth, hair;
            int age, height, weight;
            double heightInCm, weightInKg;
            

            name = "Zed A. Shaw";
            age = 35;
            height = 74;  // inches
            weight = 180; // lbs
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

             heightInCm = height * 2.54; 
             weightInKg = weight * 0.453592;

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height.ToString("F2") + " inches tall.");
            Console.WriteLine("He's " + weight.ToString("F2") + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height.ToString("F2") + ", and " + weight.ToString("F2")
                               + " I get " + (age + height.ToString("F2") + weight.ToString("F2")) + ".");

            Console.ReadKey();
        }
    }
}
