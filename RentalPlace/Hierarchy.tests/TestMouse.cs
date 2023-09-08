using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.tests
{
    [TestClass]
    public class TestMouse
    {
        private Mouse mouse;
        private Food food;


        [TestInitialize]
        public void Setup()
        {
            mouse = new Mouse("mouse", "pelite", 3.0, "dungeon");
        }

        [TestMethod]
        public void Mouse_Check_AreEqual_To_String()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            mouse.MakeSound();

            string expectedOutput = "Squeak! Squeak!" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, sw.ToString());
        }

        [TestMethod]
        public void The_Right_Amount_Of_Food_Eaten()
        {
            food = new Vegetable(5);
            mouse.Eat(food);

            string mouseToString = mouse.ToString();

            if (int.TryParse(mouseToString, out int actualFoodEaten))
            {
                int expectedFoodEaten = 5;
                Assert.AreEqual(expectedFoodEaten, actualFoodEaten);
            }
        }

        [TestMethod]
        public void Wrong_Food_Throw_Wrong_Food_Exception()
        {
            food = new Meat(5);

            Assert.ThrowsException<WrongFoodException>(() => mouse.Eat(food));
        }
    }
}
