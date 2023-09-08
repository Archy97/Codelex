using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.tests
{
    [TestClass]
    public class TestTiger
    {
        private Tiger tiger;
        private Food food;


        [TestInitialize]
        public void Setup()
        {
            tiger = new Tiger("tiger", "lauvins", 300.0, "africa");
        }

        [TestMethod]
        public void Check_AreEqual_To_String()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            tiger.MakeSound();

            string expectedOutput = "RooaRRR!" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, sw.ToString());
        }

        [TestMethod]
        public void The_Right_Amount_Of_Food_Eaten()
        {
            food = new Meat(5);
            tiger.Eat(food);

            string mouseToString = tiger.ToString();

            if (int.TryParse(mouseToString, out int actualFoodEaten))
            {
                int expectedFoodEaten = 5;
                Assert.AreEqual(expectedFoodEaten, actualFoodEaten);
            }
        }

        [TestMethod]
        public void Wrong_Food_Throw_Wrong_Food_Exception()
        {
            food = new Vegetable(5);

            Assert.ThrowsException<WrongFoodException>(() => tiger.Eat(food));
        }
    }
}
