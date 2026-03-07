// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CountNoOfValid
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements separated by space:");
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
                arr[i] = int.Parse(input[i]);

            Console.WriteLine("Enter value of d:");
            int d = int.Parse(Console.ReadLine());

            int result = CountNoOf_char. CountTriplets(arr, d);
            Console.WriteLine("Number of valid triplets: " + result);
        }

    }
}

