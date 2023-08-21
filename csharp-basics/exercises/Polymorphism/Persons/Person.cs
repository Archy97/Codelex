using System;

namespace Persons
{
    public abstract class Person
    {
        protected string FirstName { get; }
        protected string LastName { get; }
        protected string Address { get; }
        protected int Id { get; }

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"ID: {Id}");
        }
    }
}