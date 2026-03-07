using System;
using System.Collections.Generic;
using System.Text;

namespace GrossSalaryCal
{
    internal class GrossSalary
    {
        public static int CalGross(int BP, int WD)
        {
            if (BP < 0)
                return -1;

            if (BP > 10000)
                return -2;

            if (WD > 31)
                return -3;

            int da = (int)(0.75 * BP);
            int hra = (int)(0.50 * BP);

            int grosSal = BP + da + hra;
            return grosSal;
        }
    }
}
