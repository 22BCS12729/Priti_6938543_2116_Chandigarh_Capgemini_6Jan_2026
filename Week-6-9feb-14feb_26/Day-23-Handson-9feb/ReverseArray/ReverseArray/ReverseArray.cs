using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseArray
{
    internal class ReverseArray
    {
       public static void ArrayReV(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}

