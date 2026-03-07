// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueWords
{
    internal class Program
    {
        static void Main()
        {
            string[] words = { "listen", "silent", "hello", "world", "abc", "cba" };
            UniueWords.FindUnique(words);
        }
    }
}

