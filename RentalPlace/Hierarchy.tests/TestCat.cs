using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.tests
{
    [TestClass]
    public class TestCat
    {
        private Cat cat;
        private Food food;

        [TestInitialize]
        public void Setup()
        {
            cat = new Cat("cat", "fluffy", 5.0, "austria", "persian");
            food = new Vegetable(5);
        }

        [TestMethod]
        public void Cat_Check_AreEqual_To_String()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            cat.MakeSound();

            string expectedOutput = "Meow! Meow!" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, sw.ToString());
        }

        [TestMethod]
        public void The_Right_Amount_Of_Food_Eaten()
        {
            cat.Eat(food);

            string catToString = cat.ToString();

            if (int.TryParse(catToString, out int actualFoodEaten))
            {

                int expectedFoodEaten = 5;
                Assert.AreEqual(expectedFoodEaten, actualFoodEaten);
            }
        }
    }
}