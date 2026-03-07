// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace SortSeperatedWord
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter pipe separated words: ");
            string input = Console.ReadLine();

            Console.WriteLine(SotSepWord.SortWords(input));
        }

    }
}
