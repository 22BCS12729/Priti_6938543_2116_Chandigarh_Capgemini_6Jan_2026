using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumber
{
    internal class LuckyNumber
    {
        
            public static int luckynumbers(int m, int n)
            {
                int output = 0;

                for (int i = m; i <= n; i++)
                {
                    int cnt = 0;  
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            cnt++;
                        }
                    }
                    if (cnt != 2)
                    {
                        if (sumof(i * i) == (sumof(i) * sumof(i)))
                        {
                            output++;
                        }
                    }
                }
                return output;
            }

            public static int sumof(int number)
            {
                int sum = 0;

                while (number > 0)
                {
                    sum = sum + (number % 10);
                    number = number / 10;
                }
                return sum;
            }
        }
    }

