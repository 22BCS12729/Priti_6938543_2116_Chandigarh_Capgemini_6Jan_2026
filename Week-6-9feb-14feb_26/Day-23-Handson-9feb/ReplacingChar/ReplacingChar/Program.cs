// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveAlternateChar
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string outp= removeAlt.DelAlt(s);
            Console.WriteLine(outp);

        }
    }
}
