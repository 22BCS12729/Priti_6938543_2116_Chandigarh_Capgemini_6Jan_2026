using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SortArray
    {
        static void Main()
        {
            Console.Write("Enter the size of the element:");
            int n;
            n = int.Parse(Console.ReadLine());

            int[] a1 = new int[n];
            int[] b1 = new int[n];
            int[] out1 = new int[n];

            if (n < 0)
            {
                out1[0] = -2;
                Console.WriteLine(out1[0]);
            }
            Console.WriteLine("Enter the a1 elements");
            for (int i = 0; i < n; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
                if (a1[i] < 0)
                {
                    out1[0] = -1;
                    Console.WriteLine(out1[0]);
                }

            }
            Console.WriteLine("Enter the b1 elements");
            for (int i = 0; i < n; i++)
            {
                b1[i] = int.Parse(Console.ReadLine());
                if (b1[i] < 0)
                {
                    out1[0] = -1;
                    Console.WriteLine(out1[0]);
                }
            }

            Array.Sort(a1);
            Array.Sort(b1);
            Array.Reverse(b1);


            for(int i = 0; i < n; i++)
            {
                out1[i] = a1[i] * b1[n - 1 - i];
            }
            Console.WriteLine("Output array:");
            foreach(int x in out1)
            {
                Console.WriteLine(x);
            }

        }
    }
}
