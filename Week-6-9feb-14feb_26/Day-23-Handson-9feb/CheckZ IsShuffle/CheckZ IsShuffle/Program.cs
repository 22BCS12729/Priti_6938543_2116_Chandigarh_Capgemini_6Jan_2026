// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckZ_IsShuffle
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter string x: ");
            string x = Console.ReadLine();

            Console.Write("Enter string y: ");
            string y = Console.ReadLine();

            Console.Write("Enter string z: ");
            string z = Console.ReadLine();

            Console.WriteLine(Zshiffle.IsPerfectShuffle(x, y, z));
        }
    }
}

