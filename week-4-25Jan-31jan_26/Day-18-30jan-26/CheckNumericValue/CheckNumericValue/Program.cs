// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckNumericValue
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                arr[i] = Console.ReadLine();

            Console.WriteLine(CheckValue.CheckNumericArray(arr));
        }
    }
}

