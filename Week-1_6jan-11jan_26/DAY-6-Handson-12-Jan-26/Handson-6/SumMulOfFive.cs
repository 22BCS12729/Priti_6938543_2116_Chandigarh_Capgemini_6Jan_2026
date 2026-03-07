using System;
using System.Collections.Generic;
using System.Text;

namespace Handson_6
{
    internal class SumMulOfFive
    {
        static void Main()
        {
            Console.WriteLine("Enter array size:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
                return;
            }

            int[] arr = new int[n];
            int sum = 0, count = 0;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                if (arr[i]%5 == 0)
                {
                    sum+=arr[i];
                    count++;
                }
            }
            if (count > 0)
            {
                double avg = (double)sum / count;
                Console.WriteLine("Sum=" + sum);
                Console.WriteLine("Average=" + avg);
            }
            else
            {
                Console.WriteLine("Not Multiple of 5");
            }
        }
    }
}