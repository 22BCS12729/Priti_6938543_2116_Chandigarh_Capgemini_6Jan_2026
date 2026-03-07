using System;
using System.Collections.Generic;
using System.Text;

namespace SumLargetsNoRange
{
    internal class SumOflargestNo
    {
        public static int LargestNo(int[] inp1)
        {
            bool negative = false;
            bool greater = false;

            HashSet<int> unique = new HashSet<int>();

            foreach (int num in inp1)
            {
                if (num < 0)
                {
                    negative = true;
                }
                if (num == 0 || num > 100)
                {
                    greater = true;
                }
                unique.Add(num);

            }
            if (negative && greater)
                return -3;
            if (negative)
                return -1;
            if (greater)
                return -2;
            int sum = 0;
            
            for(int st = 1; st <= 91; st += 10)
            {
                int end = st + 9;
                int maxrange = -1;

                foreach(int num in unique)
                {
                    if(num>=st && num <= end)
                    {
                        if (num > maxrange)
                            maxrange = num;
                    }
                }
                if (maxrange != -1)
                    sum += maxrange;
            }
            return sum;

        }
    }
}
