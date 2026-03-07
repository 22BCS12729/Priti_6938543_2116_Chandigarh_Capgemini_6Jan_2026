using System;
using System.Collections.Generic;
using System.Text;

namespace SearcElement
{
    internal class SearchElementArray
    {
        static void Main()
        {
            int[] arr = { 4, 7, 2, 9 };
            int size = arr.Length;
            int search = 7;
            bool found = false;

            if (size < 0)
            {
                Console.WriteLine(-2);
                return;
            }

            foreach (int x in arr)
            {
                if (x < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }

                if (x == search)
                    found = true;
            }

            if (found)
                Console.WriteLine(1);
            else
                Console.WriteLine(-3);
        }
    }
}
