using System;

public enum DaysName
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        foreach (DaysName day in Enum.GetValues(typeof(DaysName)))
        {
            Console.WriteLine(day);
        }
    }
}