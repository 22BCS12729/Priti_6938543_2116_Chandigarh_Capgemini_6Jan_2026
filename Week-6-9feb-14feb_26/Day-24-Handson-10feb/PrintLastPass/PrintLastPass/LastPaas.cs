using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLastPass
{
    internal class LastPaas
    {
        public static void PrintLastPass(int n, int t)
        {
            int from = GetHolder(n, t - 1);
            int to = GetHolder(n, t);

            Console.WriteLine("In last second, Friend " + from + " passed the ball to Friend " + to);
        }

        static int GetHolder(int n, int second)
        {
            return (second % n) + 1;
        }
    }
}

