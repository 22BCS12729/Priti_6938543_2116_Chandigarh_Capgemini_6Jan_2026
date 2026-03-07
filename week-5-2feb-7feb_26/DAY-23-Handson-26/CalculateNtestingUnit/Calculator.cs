using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateNtestingUnit
{
   public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a-b;

        public int Multiply(int a, int b) => a*b;

        public double Divide(int a,int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot Divide By Zero");
            return (double)a/b;
        }

    }
}
