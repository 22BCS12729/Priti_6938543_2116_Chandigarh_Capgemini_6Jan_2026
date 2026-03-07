using System;
using System.Collections.Generic;
using System.Text;

namespace FindMissingNumber
{
    internal class FindeMissNo
    {
       public  static int FindMissingNumber(int[] arr)
        {
            int n = arr.Length + 1;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in arr)
                actualSum += num;

            return expectedSum - actualSum;
        }
    }

}

