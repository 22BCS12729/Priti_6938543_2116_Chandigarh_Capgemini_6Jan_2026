using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SumOfPrimes
    {
        static void Main()
        {
            Console.Write("Enter the Array size: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
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

            int sum = 0;
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                int num = a1[i];
                int factorCount = 0;

                if (num > 1)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            factorCount++;
                        }
                    }

                    if (factorCount == 2)
                    {
                        sum += num;
                        cnt++;
                    }
                }
            }

            if (cnt == 0)
            {
                Console.WriteLine(-3);
                return;
            }

            Console.WriteLine("The Sum Is-"+sum);
            Console.ReadLine();
        }
       
    }
}
