using System;
using System.Collections.Generic;
using System.Text;

namespace AddElementArrays
{
    internal class AddArrayElem
    {
        public static int[] AddArray(int[] inp1, int[] inp2, int n)
        {
            if (n < 0)
            {
                return new int[] { -2 };
            }

            for(int i = 0; i < n; i++)
            {
                if (inp1[i] < 0 || inp2[i] < 0)
                {
                    return new int[] { -1 };
                }
            }
            int []output=new int[n];
            for(int i = 0; i < n; i++)
            {
                output[i] = inp1[i] + inp2[n - 1 - i];
            }
            return output;
        }

    }
}
