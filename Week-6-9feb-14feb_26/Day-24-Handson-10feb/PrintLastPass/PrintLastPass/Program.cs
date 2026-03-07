// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLastPass
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of friends:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of seconds:");
            int t = int.Parse(Console.ReadLine());

            LastPaas.PrintLastPass(n, t);
        }
    }
}

