using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture;

namespace LectureTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add5and8()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(5, 3);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Add4and10()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(4, 10);

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void AddNegative4and10()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(-4, 10);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AddNegative4andnegative10()
        {
            Calculator calc = new Calculator(); //ARRANGE
            int result = calc.Add(-4, -10); //ACT

            Assert.AreEqual(-14, result); //assert
        }
    }

}
