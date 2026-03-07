// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace FormString
{
    internal class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            string[] input1 = new string[k];

            for (int i = 0; i < k; i++)
            {
                input1[i] = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            string output =Stringform.formString(input1, n);
            Console.WriteLine(output);
        }
    }
}

