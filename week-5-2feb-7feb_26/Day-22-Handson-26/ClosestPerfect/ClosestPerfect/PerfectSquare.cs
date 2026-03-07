using System;
using System.Collections.Generic;
using System.Text;

namespace ClosestPerfect
{
    internal class PerfectSquare
    {
        public static int perfect(int n)
        {
            int root = (int)Math.Sqrt(n);
            int ls = root * root;
            int us=(root+1)*(root+1);
            if (n - ls <= us - n)
                return ls;
            else return us;
        }
    }
}
