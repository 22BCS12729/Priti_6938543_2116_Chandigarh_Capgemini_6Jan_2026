using System;
using System.Collections.Generic;
using System.Text;

namespace AvgMul
{
    internal class AvgMulUpToN
    {
      public  static int AverageOfMultiplesOfFive(int n)
        {
            if (n < 0)
                return -1;

            if (n > 500)
                return -2;

            int sum = 0;
            int count = 0;

            for (int i = 5; i <= n; i += 5)
            {
                sum += i;
                count++;
            }

            return sum/count;
        }

    }
}
