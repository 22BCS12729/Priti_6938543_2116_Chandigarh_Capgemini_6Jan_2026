// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMissingNumber
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter sequence elements (comma-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(','), x => int.Parse(x.Trim()));

            int missing = FindeMissNo.FindMissingNumber(arr);
            Console.WriteLine("Missing Number: " + missing);
        }
    }
}
