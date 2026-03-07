// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromScore
{
    internal class Program
    {
        static void Main()
        {
            string str = "ABCBAAAA";
            Console.WriteLine(Palindrom.CalculateScore(str));
        }

    }
}

