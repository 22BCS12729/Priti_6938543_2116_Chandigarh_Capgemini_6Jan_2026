using System;

namespace ConsoleApp1
{
    internal class SwapArrayElements
    {
        static void Main()
        {
            Console.WriteLine("Enter the Size of the Array:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
                return;
            }

            if (n % 2 == 0)
            {
                Console.WriteLine(-3);
                return;
            }

            int[] a1 = new int[n];
            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < n; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
                if (a1[i] < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            int mid = n / 2;

            for (int i = 0; i < mid; i++)
            {
                int temp = a1[i];
                a1[i] = a1[n - 1 - i];
                a1[n - 1 - i] = temp;
            }

            Console.WriteLine("Output array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a1[i] + " ");
            }
        }
    }
}
