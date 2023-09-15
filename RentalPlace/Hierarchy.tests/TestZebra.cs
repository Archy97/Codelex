using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.tests
{
    [TestClass]
    public class TestZebra
    {
        private Zebra zebra;
        private Food food;

        [TestInitialize]
        public void Setup()
        {
            zebra = new Zebra("zebra", "horsy", 500.0, "africa");
        }

        [TestMethod]
        public void Mouse_Check_AreEqual_To_String()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            zebra.MakeSound();

            string expectedOutput = "Zebra sound!" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, sw.ToString());
        }

        [TestMethod]
        public void The_Right_Amount_Of_Food_Eaten()
        {
            food = new Vegetable(5);
            zebra.Eat(food);

            string mouseToString = zebra.ToString();

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

            Assert.ThrowsException<WrongFoodException>(() => zebra.Eat(food));
        }
    }
}
