using System;
using System.Collections.Generic;
using System.Text;

namespace SquareOfOddDigit
{
    internal class SquarOddDigit
    {
        public static int SumOfSquaresOfOddDigits(int n)
        {
            if (n < 0)
                return -1;

            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                    sum += digit * digit;

                n /= 10;
            }
            return sum;
        }

    }
}
