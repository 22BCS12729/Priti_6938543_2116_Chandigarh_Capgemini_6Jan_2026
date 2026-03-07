// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumDeletion
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int res = MaxDeletion.Maximum(s);
            Console.WriteLine(res);
        }
    }
}

