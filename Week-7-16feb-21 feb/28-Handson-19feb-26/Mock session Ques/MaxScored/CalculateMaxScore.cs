using System;
using System.Collections.Generic;
using System.Text;

namespace MaxScored
{
    internal class CalculateMaxScore
    {

       public  static bool IsValid(int m)
        {
            return m >= 0 && m <= 100;
        }
        public static int Calculate(int sub)
        {
            int max = int.MinValue;


            for(int i = 1; i < sub; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (!IsValid(m))
                {

                    Console.WriteLine("You have Entered invalid mark");
                    return -1;
                }
                if (m > max)
                {
                    max = m;
                }
            }
            return max;
        }
    }
}
