using System;
using System.Collections.Generic;
using System.Text;

namespace MinimumOperation
{
    internal class MinOperation
    {
        public static int minOperation(int n)
        {
    //        int curr = 10;
              int steps = 0;


            //        while (curr != n)
            //        {
            //            if (curr * 3 <= n)
            //            {
            //                curr*= 3;
            //            }
            //            else if (curr + 2 <= n)
            //            {
            //                curr += 2;
            //            }
            //            else
            //            {
            //                curr -= 1;
            //            }
            //            steps++;
            //        }
            //        return steps;


            while (n != 10)
            {
                if (n > 10)
                {
                    if (n % 3 == 0)
                    {
                        n = n / 3;
                    }
                    else if ((n + 1) % 3 == 0)
                    {
                        n = n + 1;
                    }
                    else
                    {
                        n = n - 1;
                    }
                }
                else
                {
                    n = n + 1;
                }
                steps++;
            }
            return steps;
      }
    }
}
