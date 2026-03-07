using System;
using System.Collections.Generic;
using System.Text;

namespace MarksValidation
{
    internal class Marks
    {
        public static bool CheckMarks(int x, int y, int n1, int n2, int m, out int t1, out int t2)
        {
            t1 = 0;
            t2 = 0;
            for (int i = n1; i >= 0; i--)
            {
                int rem = m - (i * x);

                if (rem < 0)
                    continue;

                if (rem % y == 0)
                {
                    int b = rem / y;

                    if (b >= 0 && b <= n2)
                    {
                        t1 = i;
                        t2 = b;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
