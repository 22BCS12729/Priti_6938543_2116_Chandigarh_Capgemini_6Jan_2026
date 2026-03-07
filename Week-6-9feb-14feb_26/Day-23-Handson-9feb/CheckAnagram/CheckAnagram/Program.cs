// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAnagram
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter comma separated words:");
            string input = Console.ReadLine();
            string[] words = input.Split(',');

            bool result = CheckAnagram.AreAllAnagrams(words);

            Console.WriteLine(result);
        }

    }
}
