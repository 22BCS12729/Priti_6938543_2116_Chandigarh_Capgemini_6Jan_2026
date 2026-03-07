// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace PosInteger
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            long number = Convert.ToInt64(Console.ReadLine());

            long result =PositiveInt .SumOfDigits(number);

            Console.WriteLine("Sum of digits = " + result);
        }
    }
}


