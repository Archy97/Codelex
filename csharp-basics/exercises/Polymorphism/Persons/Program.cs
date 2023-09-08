using System;
using System.Net;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "Doe", "123 Main St", 12345, 3.8);
            student.Display();
            Console.WriteLine();
           
            Employee employee = new Employee("Jane", "Smith", "456 Oak Ave", 98765, "Manager");
            employee.Display();
        }
    }
}