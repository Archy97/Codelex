using System;

namespace Exe_6
{
    public class Dog
    {
        public string Name;
        public string Gender;
        public Dog Mother;
        public Dog Father;


        public Dog ( string name, string gender)
        {
            Name = name;
            Gender = gender;
        }


         public string FathersName()
        {
            return (Father != null) ? Father.Name : "Unknown";
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return Mother.Name == otherDog.Mother.Name;
        }


    }









    internal class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            max.Mother = lady;
            max.Father = rocky;

            coco.Mother = molly;
            coco.Father = buster;

            rocky.Mother = molly;
            rocky.Father = sam;

            buster.Mother = lady;
            buster.Father = sparky;

               string father1 = coco.FathersName();
               string father2 = sparky.FathersName();
              bool sameMother = rocky.HasSameMotherAs(coco);

            Console.WriteLine(father1);
            Console.WriteLine(father2);
            Console.WriteLine(sameMother);
        }   
    }
}