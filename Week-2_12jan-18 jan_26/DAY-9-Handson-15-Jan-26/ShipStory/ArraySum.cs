using System;
using System.Collections.Generic;
using System.Text;

namespace ShipStory
{
    internal class ArraySum
    {

        public static int[] AddFrontWithBack(int[] arr1, int[] arr2, int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
                return new int[] { -2 };

            for (int i = 0; i < n1; i++)
            {
                if (arr1[i] < 0)
                    return new int[] { -1 };
            }

            for (int i = 0; i < n2; i++)
            {
                if (arr2[i] < 0)
                    return new int[] { -1 };
            }

            int size = Math.Min(n1, n2);
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = arr1[i] + arr2[n2 - 1 - i];
            }

            return result;
        }
    }
}
