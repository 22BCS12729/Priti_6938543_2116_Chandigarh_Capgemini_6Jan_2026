using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    internal class ArmstrongNo
    {
        static void Main()
        {
            int n;
            int out1;
            int cnt = 0;
            int org;
            int sum = 0;

            int digit;

            Console.Write("Enter the Number:-");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                out1 = -1;
            }
            else if (n >= 1000)
            {
                out1 = -2;
            }
            else
            {

                org = n;
                while (org > 0)
                {
                    cnt++;
                    org = org / 10;
                }
                org = n;
                while (org > 0)
                {
                    digit = org % 10;
                    sum += (int)Math.Pow(digit, cnt);
                    org = org / 10;
                }
                if (sum == n)
                    out1 = 1;
                else
                    out1 = 0;
            }
            Console.WriteLine("The variable output1=" + out1);
        }
    }
}

