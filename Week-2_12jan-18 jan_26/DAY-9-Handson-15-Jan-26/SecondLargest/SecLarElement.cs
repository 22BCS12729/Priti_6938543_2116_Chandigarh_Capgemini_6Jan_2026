using System;
using System.Collections.Generic;
using System.Text;

    namespace SecondLargest
    {
        internal class SecLarElement
        {
        public static int secondLarEle(int n, int[] arr)
        {
            if (n < 0)
            {
                return -2;
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    return -1;
                }
            }

            int largest = int.MinValue;
            int secLargest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    secLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] < largest && arr[i] > secLargest)
                {
                    secLargest = arr[i];
                }
            }

            return secLargest;
        }
        }
    }
