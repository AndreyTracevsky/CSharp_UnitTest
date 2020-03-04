using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyCalculator.BL.Tests
{
    [TestClass]
    public class MyCalculatorTests
    {
        [DataTestMethod]
        [DataRow(-1, 1, 0)]
        [DataRow(10, 11, 21)]
        [DataRow(11, 1, 12)]
        [DataRow(10, 1, 11)]


        public void SummWithDifrentValue(double left, double right, double expected)
        {
            var calculator = new MyCalculator();
            var actual = calculator.Summ(left, right);
            Assert.AreEqual(expected, actual);

            // arrange
            //double left = 10;
            //double right = 20;
            //double expected = left + right;
            //double epsilon = 0.00000001;

            // act
            //MyCalculator calculator = new MyCalculator();
            //double actual = calculator.Summ(left, right);

            // assert
            //if (Math.Abs(expected - actual) < epsilon)
            //{
            //    Assert.AreEqual(0, 0);
            //}
            //else
            //{
            //    Assert.AreEqual(0, 1);
            //}
            
        
        }
    }
}
