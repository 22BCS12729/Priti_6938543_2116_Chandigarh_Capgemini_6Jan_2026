// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitsum_in_String
{
    internal class Program
    {
        static void Main() {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            for (int i = 0; i < n; i++) {
                input[i] = Console.ReadLine();
                int res = DigitsuminString.sumOfDigit(input);
                Console.WriteLine(res);

            }
        }
    }
}

