using System;
using System.Collections.Generic;
using System.Text;

namespace CalSalSaving
{
    internal class SavingCal
    {
        public static int Calculate(int sal,int days)
        {
            if (sal > 9000)
                return -1;

            if (sal < 0)
                return -2;

            if (days < 0)
                return -4;

            int saving = (int)(sal * 0.30);

            if (days == 31)
                saving += 500;
            return saving;
        }
    }
}
