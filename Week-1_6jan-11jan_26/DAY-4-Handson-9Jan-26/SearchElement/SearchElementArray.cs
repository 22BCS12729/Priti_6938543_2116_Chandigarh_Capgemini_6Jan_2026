using System;
using System.Collections.Generic;
using System.Text;

namespace SearchElement
{
    internal class SearchElementArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
                return;
            }
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
            int temp = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == temp)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(1);
        }
    }
}
