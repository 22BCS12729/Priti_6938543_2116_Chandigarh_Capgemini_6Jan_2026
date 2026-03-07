// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace PositiveInteger
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the pos integer");
            string num = Console.ReadLine();
            int res = Positive.SumOfDigit(num);
            return res;
        }
    }
}
