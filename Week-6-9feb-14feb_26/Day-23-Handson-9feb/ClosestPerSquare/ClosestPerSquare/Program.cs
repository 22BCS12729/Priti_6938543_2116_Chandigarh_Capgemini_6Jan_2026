// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace ClosestPerSquare
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            long number = Convert.ToInt64(Console.ReadLine());

            long result = ClosPerSq.ClosestPerfectSquare(number);

            Console.WriteLine("Closest perfect square = " + result);
        }
    }
}


