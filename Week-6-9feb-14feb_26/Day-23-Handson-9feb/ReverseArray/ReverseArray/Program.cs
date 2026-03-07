// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseArray
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            ReverseArray.ArrayReV(arr);

            Console.WriteLine("Reversed Array:");
            foreach (int num in arr)
                Console.Write(num + " ");
        }
    }
}
