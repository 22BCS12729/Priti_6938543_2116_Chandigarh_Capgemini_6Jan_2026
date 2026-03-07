using System;
using System.Collections.Generic;
using System.Text;

namespace AvgEvenOdd
{
    internal class EvenOddAvg
    {
        public static int Average(int[] arr, int n) {
            if (n < 0)
                return -2;

            int sumOdd = 0;
            int sumEven = 0;

            for(int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                    return -1;

                if (arr[i] % 2 == 0)
                    sumEven += arr[i];

                else
                    sumOdd += arr[i];
                
            }

            int password = (sumEven + sumEven )/ 2;

            return password;
        }
    }
}
