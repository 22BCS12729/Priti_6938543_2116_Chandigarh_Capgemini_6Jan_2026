using System;
using System.Collections.Generic;
using System.Text;

namespace MergeArray
{
    internal class MergerTwoArray
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    result[k++] = arr1[i++];
                else
                    result[k++] = arr2[j++];
            }

            while (i < arr1.Length)
                result[k++] = arr1[i++];

            while (j < arr2.Length)
                result[k++] = arr2[j++];

            return result;
        }
    }
}

