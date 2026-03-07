// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveLastOccurence
{
    internal class Program
    {
        static void Main()
        {
            string str = "I am a programmer. I learn at Codeforwin.";
            string word = "I";

            Console.WriteLine(RemLasOcu.tyRemoveLast(str, word));
        }
    }
}
