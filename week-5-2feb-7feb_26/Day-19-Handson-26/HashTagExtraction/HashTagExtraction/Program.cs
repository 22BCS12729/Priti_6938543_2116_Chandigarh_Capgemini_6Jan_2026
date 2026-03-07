// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace HashTagExtraction
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            ExtractHashtag.Extract(input);
        }
    }
}

