using System;
using System.Collections.Generic;
using System.Text;

namespace LargestElement
{
    internal class SecLargets
    {
       public static int FindSecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int second = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    second = largest;
                    largest = num;
                }
                else if (num > second && num != largest)
                {
                    second = num;
                }
            }

            return second;
        }
    }
}

