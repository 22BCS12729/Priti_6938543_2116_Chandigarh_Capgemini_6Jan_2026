using System;
using System.Collections.Generic;
using System.Text;

namespace PositiveInteger
{
    internal class Positive
    {
        public static int SumOfDigit(int num)
        {
            int sum = 0;
            foreach(char ch in num)
            {
                sum += ch - '0';
            }
            return sum;
        }
    }
}
