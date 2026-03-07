using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CountMultiples3
    {
        static void Main()
        {
            Console.Write("Enter the sIze:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
                return;
            }
            int[] a1 = new int[n];
            int cnt = 0;

            Console.WriteLine("Enter the Array Elements");
            for (int i = 0; i < n; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());


                if (a1[i] < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                if (a1[i] % 3 == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine("The Count of the elements are:-");
            Console.WriteLine(cnt);
        }
    }
}
