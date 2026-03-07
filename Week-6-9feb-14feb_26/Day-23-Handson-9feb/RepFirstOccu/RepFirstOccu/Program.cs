// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace RepFirstOccu
{
    internal class Program
    {
        static void Main()
        {
            string str = "I love programming.";
            Console.WriteLine(RepFirstOccurence.ReplaceFirst(str, '.', '!'));
        }
    }
}
