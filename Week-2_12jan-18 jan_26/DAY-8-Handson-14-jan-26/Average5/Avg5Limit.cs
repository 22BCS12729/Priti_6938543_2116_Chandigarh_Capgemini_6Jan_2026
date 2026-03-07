using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml;

namespace Average5
{
   internal class Avg5Limit
    {
        static void Main()
        {
            Console.Write("Enter the size:-");
            int input1;
            
            input1 = int.Parse(Console.ReadLine());
            int output;
            if (input1 < 0)
            {
                output= -1;
            }
            else
            {
                int sum = 0;
                int cnt = 0;

                

                for (int i = 1; i <= input1; i++)
                {
                    if (i % 5 == 0)
                    {
                        sum += i;
                        cnt++;
                    }

                }
                if (cnt > 0)
                {
                    output = sum / cnt;
                }
                else
                {
                    output = 0;
                }
                Console.WriteLine("Output=" + output);
            }
        }
    }
}
