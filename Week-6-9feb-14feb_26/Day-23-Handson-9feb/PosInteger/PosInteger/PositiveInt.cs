using System;
using System.Collections.Generic;
using System.Text;

namespace PosInteger
{
    internal class PositiveInt
    {
      public  static long SumOfDigits(long number)
        {
            long sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
