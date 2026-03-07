using System;
using System.Collections.Generic;
using System.Text;

namespace ProdOfMaxMin
{
    internal class ProdOfMaxMin
    {
        public static int Product(int n, int[] arr)
        {
            if (n < 0)
                return -2;


            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                    return -1;

                if (arr[i]<min)
                    min=arr[i];

                if (arr[i] > max)
                    max=arr[i]; 
            }
            return min*max;
            
        }
    }
}
