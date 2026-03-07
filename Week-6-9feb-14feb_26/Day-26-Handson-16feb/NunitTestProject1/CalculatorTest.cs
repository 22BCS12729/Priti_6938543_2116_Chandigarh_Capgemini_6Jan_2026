//using CalculateNtestingUnit;
//using System;
//using System.Collections.Generic;
//using System.Text;

using CalculateNtestingUnit;
using NUnit.Framework;

namespace NunitTestProject1
{
    [TestFixture]
    internal class CalculatorTest
    {
        private Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            int a = 5;
            int b = 3;

            int result = calc.Add(a, b);

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnDifference()
        {
            int a = 10, b = 11;

            int result = calc.Subtract(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnDivision()
        {
            int a = 10, b = 2;

            double result = calc.Divide(a, b);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}

