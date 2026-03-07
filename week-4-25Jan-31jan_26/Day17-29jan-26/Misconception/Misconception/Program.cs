// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace Misconception
{
    internal class Program
    {
        static void Main()
        {
            string s=Console.ReadLine();
           string output= MisconecptionProb.Check(s);
            Console.WriteLine(output);
        }
    }
}