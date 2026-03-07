using System;
using System.Collections.Generic;
using System.Text;

namespace MulSum
{
    internal class FactorSum
    {
        public static int FacSum(int inp1, int inp2)
        {
            if (inp1 < 0)
                return -1;
            if (inp2 > 32627)
                return -2;

            int sum = 0;
            for (int i = inp1; i <= inp2; i++)
            {
                if (i % inp1 == 0)
                {
                    sum += i;

                }
            }
            return sum;

        }
    }
}
