using System;
using System.Collections.Generic;
using System.Text;

namespace RemNegElements
{
    internal class RemoveNeg
    {
        static void Main()
        {
            int[] arr = { -2, 4, 1, -5, 3 };
            int n = arr.Length;

            if (n < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            List<int> list = new List<int>();
            foreach (int x in arr)
            {
                if (x >= 0)
                {
                    list.Add(x);
                }
            }

                list.Sort();
                foreach(int x in list) {
                    Console.WriteLine(x + " ");
            }
        }
    }
}
