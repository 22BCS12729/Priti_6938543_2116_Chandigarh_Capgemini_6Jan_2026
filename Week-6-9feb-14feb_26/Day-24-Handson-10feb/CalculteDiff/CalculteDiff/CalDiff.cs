using System;
using System.Collections.Generic;
using System.Text;

namespace CalculteDiff
{
    internal class CalDiff
    {
       public  static void CalculateDifference(string input1, string input2)
        {
            string[] list1 = input1.Split(',');
            string[] list2 = input2.Split(',');

            foreach (string item1 in list1)
            {
                int n = int.Parse(item1.Trim());
                int sum = 0;

                foreach (string item2 in list2)
                {
                    int m = int.Parse(item2.Trim());
                    if (m == n)
                    {
                        sum += m;
                    }
                }

                Console.WriteLine(n + "-" + sum);
            }
        }
    }

}

