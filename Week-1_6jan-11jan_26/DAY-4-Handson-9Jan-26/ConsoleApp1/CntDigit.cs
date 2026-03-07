using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CntDigit
    {
        static void Main()
        {
            Console.Write("Enter the Number-");
            int n;
            int cnt = 0;
            int out1;

            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                out1 = -1;
            }
            else if (n == 0)
            {
                out1 = 1;
            }
            else {

                while (n > 0)
                {
                    cnt++;
                    n /= 10;
                }
                out1 = cnt;
            }

            Console.WriteLine("The Output1 Variable = " + out1);
        }
    }
}

