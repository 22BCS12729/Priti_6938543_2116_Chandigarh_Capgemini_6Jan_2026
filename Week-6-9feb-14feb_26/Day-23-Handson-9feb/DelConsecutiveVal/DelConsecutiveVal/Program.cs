// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace DelConsecutiveVal
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine();

            Console.WriteLine(DelConsecutive.DeleteVowelPairs(s));
        }
    }
}

