// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculteDiff
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the first list of integers (comma-separated): ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second list of integers (comma-separated): ");
            string input2 = Console.ReadLine();

            CalDiff.CalculateDifference(input1, input2);
        }

    }
}

