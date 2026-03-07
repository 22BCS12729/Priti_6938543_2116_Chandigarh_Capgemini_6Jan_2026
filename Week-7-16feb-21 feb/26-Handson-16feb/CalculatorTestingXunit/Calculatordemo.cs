using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTestingXunit
{

    public class Calculatordemo
    {
        private readonly Calculator calc = new Calculator();

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            int result = calc.Add(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            int result = calc.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            int result = calc.Multiply(7, 6);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }

        [Theory]
        [InlineData(20, 4, 5)]
        [InlineData(9, 3, 3)]
        public void Divide_ReturnsCorrectResult(int a, int b, double expected)
        {
            double result = calc.Divide(a, b);
            Assert.Equal(expected, result);
        }
    }
}
