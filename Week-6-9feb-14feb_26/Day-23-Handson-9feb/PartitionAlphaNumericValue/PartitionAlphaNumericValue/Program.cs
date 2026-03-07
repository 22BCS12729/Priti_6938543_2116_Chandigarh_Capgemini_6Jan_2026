// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace PartitionAlphaNumericValue
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter alphanumeric string: ");
            string input = Console.ReadLine();

            Partiotion.PartitionString(input);
        }
    }
}

