// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace MergeArray
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first sorted array:");
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("Enter second sorted array:");
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] merged = MergerTwoArray. MergeArrays(arr1, arr2);

            Console.WriteLine("Merged Array:");
            foreach (int num in merged)
                Console.Write(num + " ");
        }
    }
}
