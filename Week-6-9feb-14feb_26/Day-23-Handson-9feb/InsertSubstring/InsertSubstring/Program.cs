// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace InsertSubstring
{
    internal class Program
    {
        static void Main()
        {
            string str = "C programming";
            Console.WriteLine(InsertSub.InsertAt(str, "ABC", 3));
        }
    }
}
