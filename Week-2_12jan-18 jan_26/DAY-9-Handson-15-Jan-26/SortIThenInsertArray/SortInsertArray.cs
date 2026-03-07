using System;
using System.Collections.Generic;
using System.Text;

namespace SortIThenInsertArray
{
    internal class SortInsertArray
    {
        public static int[] InsertElement(int n, int[]arr,int x)
        {
            if (n < 0)
            {
                return new int[] { -2 };
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            int[] newArr = new int[n + 1];
            int index = 0;
            bool inserted = false;

            for (int i = 0; i < n; i++)
            {
                if (!inserted && x <= arr[i])
                {
                    newArr[index++] = x;
                    inserted = true;
                }
                newArr[index++] = arr[i];
            }

            if (!inserted)
            {
                newArr[index] = x;
            }

            return newArr;
        }
    }
}