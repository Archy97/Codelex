using Persons;
using System;

class Employee : Person
{
    public string JobTitle { get; }

    public Employee(string firstName, string lastName, string address, int id, string jobTitle)
        : base(firstName, lastName, address, id)
    {
        JobTitle = jobTitle;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Job Title: {JobTitle}");
    }
}