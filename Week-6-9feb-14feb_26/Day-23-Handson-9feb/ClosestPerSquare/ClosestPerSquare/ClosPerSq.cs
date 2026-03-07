using System;
using System.Collections.Generic;
using System.Text;

namespace ClosestPerSquare
{
    internal class ClosPerSq
    {
       public  static long ClosestPerfectSquare(long number)
        {
            double root = Math.Sqrt(number);

            long lower = (long)Math.Floor(root);
            long upper = (long)Math.Ceiling(root);

            long lowerSquare = lower * lower;
            long upperSquare = upper * upper;

            if (number - lowerSquare <= upperSquare - number)
                return lowerSquare;
            else
                return upperSquare;
        }

    }
}
