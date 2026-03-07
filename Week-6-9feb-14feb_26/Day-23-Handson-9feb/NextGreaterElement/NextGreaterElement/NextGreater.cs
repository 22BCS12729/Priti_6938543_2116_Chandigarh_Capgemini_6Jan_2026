using System;
using System.Collections.Generic;
using System.Text;

namespace NextGreaterElement
{
    internal class NextGreater
    {
        public static int CountNextGreaterDivisible(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i] && arr[j] % arr[i] == 0)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}

