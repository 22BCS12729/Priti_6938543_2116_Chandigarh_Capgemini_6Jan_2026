// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace FileExtension
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            Console.WriteLine("Extension: " + GetExtensionFile.GetExtension(fileName));
        }
    }
}
