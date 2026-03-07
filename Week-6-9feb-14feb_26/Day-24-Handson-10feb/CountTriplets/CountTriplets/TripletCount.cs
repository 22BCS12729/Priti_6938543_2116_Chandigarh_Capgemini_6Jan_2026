using System;
using System.Collections.Generic;
using System.Text;

namespace CountTriplets
{
    internal class TripletCount
    {
       public  static int CountTriplets(int[] arr, int d)
        {
            int count = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if ((arr[i] + arr[j] + arr[k]) % d == 0)
                            count++;
                    }
                }
            }

            return count;
        }
    }
}

