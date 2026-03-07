// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(RemDuplicates.RemoveDuplicates(s));
        }

    }
}

