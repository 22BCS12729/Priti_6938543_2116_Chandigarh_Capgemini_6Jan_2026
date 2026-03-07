using System;
using System.Collections.Generic;
using System.Text;

namespace RemSearchSort
{
    internal class RemoveSearchSort
    {
       public  static int[] RemoveSearchAndSort(int[] arr, int size, int search)
        {
            if (size < 0)
                return new int[] { -2 };
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                    return new int[] { -1 };
            }
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                return new int[] { -3 };

            int[] result = new int[size - 1];
            int index = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] != search)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            Array.Sort(result);
            return result;
        }

    }
}
