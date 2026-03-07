// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumbExtraction
{
    internal class Program
    {
        static void Main()
        {
            string t = Console.ReadLine();
            PhoneNoExtract.phone(t);
        }
    }
}
