// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CountFreq
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            CountFreq.CountFrequency(arr);
        }
    }
}
