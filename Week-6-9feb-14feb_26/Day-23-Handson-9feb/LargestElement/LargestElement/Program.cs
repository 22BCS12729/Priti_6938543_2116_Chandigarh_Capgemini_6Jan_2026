// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace LargestElement
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int result = SecLargets.FindSecondLargest(arr);

            Console.WriteLine("Second Largest: " + result);
        }

    }
}
