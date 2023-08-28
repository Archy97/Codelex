using System;

class Program
{
    static void Main()
    {
        foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
        {
            Console.WriteLine(day);
        }
    }
}
