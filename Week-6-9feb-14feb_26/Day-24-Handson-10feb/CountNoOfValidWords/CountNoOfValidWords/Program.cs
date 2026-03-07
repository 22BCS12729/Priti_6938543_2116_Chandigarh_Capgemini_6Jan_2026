// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CountNoOfValidWords
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            int result = CountWords.CountValidWords(input);
            Console.WriteLine("Number of valid words: " + result);
        }
    }
}

