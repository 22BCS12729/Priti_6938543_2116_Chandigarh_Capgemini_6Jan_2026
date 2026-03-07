using System;
using System.Collections.Generic;
using System.Text;

namespace CountDivCop
{
    internal class CountDiv
    {
        public static int CountDivisibleCouples(int[] arr, int N)
        {
            int count = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int sum = arr[i] + arr[i + 1];

                if (sum % N == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
