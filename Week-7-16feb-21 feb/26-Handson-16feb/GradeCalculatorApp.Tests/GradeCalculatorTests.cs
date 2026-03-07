using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GradeCalculatorApp;

namespace GradeCalculatorApp.Tests
{
    public class GradeCalculatorTests
    {
        private readonly GradeCalculator calc = new GradeCalculator();

        [Theory]
        [InlineData(95, "A")]
        [InlineData(80, "B")]
        [InlineData(65, "C")]
        [InlineData(40, "F")]
        public void GetGrade_ReturnsExpectedGrade(int score, string expected)
        {
            // Act
            var result = calc.GetGrade(score);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

