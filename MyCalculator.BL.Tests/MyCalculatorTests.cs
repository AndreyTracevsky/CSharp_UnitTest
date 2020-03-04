using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyCalculator.BL.Tests
{
    [TestClass]
    public class MyCalculatorTests
    {
        [DataTestMethod]
        // [DataRow(double.MaxValue, double.NaN, double.MaxValue)]
        [DataRow(-1, 11, 10)]
        [DataRow(-1, -11, -12)]
        [DataRow(-10.9, 3.4, -7.5)]
        [DataRow(-10.9, -3.4, -14.3)]
        [DataRow(10.9, 3.4, 14.3)]
        [DataRow(10.9, 4, 14.9)]


        public void SummWithDifrentValue(double left, double right, double expected)
        {
            var calculator = new MyCalculator(8);
            var actual = calculator.Summ(left, right);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(5, 3, 2)]
        [DataRow(-5, 3, -8)]
        [DataRow(-10.9, 3.4, -14.3)]
        [DataRow(-10.9, -3.4, -7.5)]
        [DataRow(-10, -3, -7)]

        public void MinusWithDifrentValue(double left, double right, double expected)
        {
            var calculator = new MyCalculator(8);
            var actual = calculator.Minus(left, right);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(4, 2, 2)]
        [DataRow(10, 3, 3.33333333)] 
        

        public void DividirsesWithDifrentValue(double left, double right, double expected)
        {
            var calculator = new MyCalculator(8);
            var actual = calculator.Dividirses(left, right);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(3, 2, 6)]
        [DataRow(-5, 3, -15)]


        public void MultiplicacionsWithDifrentValue(double left, double right, double expected)
        {
            var calculator = new MyCalculator(8);
            var actual = calculator.Multiplicacions(left, right);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(16, 4)]
  
        public void Sqrt(double value, double expected)
        {
            var calculator = new MyCalculator(8);
            var actual = calculator.Sqrt(value); 
            Assert.AreEqual(expected, actual);
        }
    }
}
