using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class FatherAndMother
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

