// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace NextGreaterElement
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(NextGreater.CountNextGreaterDivisible(arr));
        }

    }
}
