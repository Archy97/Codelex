using System.Runtime.Intrinsics.X86;

namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight (kg):");
            int weightInKg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height (cm):");
            int heightInCm = int.Parse(Console.ReadLine());

            double heightInMeters = heightInCm / 100.0;
            double bmi = weightInKg / (heightInMeters * heightInMeters);
            Console.WriteLine("BMI: " + bmi.ToString("F1"));

            if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("weight is considered optimal");
            }

            else if (bmi < 18.5)
            {
                Console.WriteLine("person is considered underweight.");
            }

            else
            {
                Console.WriteLine("the person is considered overweight.");
            }
        }
    }
}