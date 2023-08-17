using System;
using System.Xml.Linq;
using PhoneBook;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDir = new PhoneDirectory();
            
            phoneDir.PutNumber("Artjoms" , "29794878");
            phoneDir.PutNumber("Janis", "9111");

            Console.WriteLine(phoneDir.GetNumber("112"));
        }
    }

}
