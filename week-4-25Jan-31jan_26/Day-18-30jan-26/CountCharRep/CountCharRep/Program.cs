// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CountCharRep
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();

            Console.WriteLine(RemoveDup.RemoveDuplicates(input));
        }
    }
}

