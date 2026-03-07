// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CountDivCop
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter N (array size): ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = CountDiv. CountDivisibleCouples(arr, N);

            Console.WriteLine("Total valid couples: " + result);
        }

    }
}

