using System;
using System.Collections.Generic;
using System.Text;

namespace DecToBinary
{
    internal class DecimalToBinary
    {
            public static int[] DecToBinary(int n)
            {
                if (n < 0)
                    return new int[] { -1 };

                if (n == 0)
                    return new int[] { 0 };

                int temp = n;
                int count = 0;
                while (temp > 0)
                {
                    count++;
                    temp /= 2;
                }
                int[] binary = new int[count];
                for (int i = count - 1; i >= 0; i--)
                {
                    binary[i] = n % 2;
                    n /= 2;
                }

                return binary;
            }
        }
    }


