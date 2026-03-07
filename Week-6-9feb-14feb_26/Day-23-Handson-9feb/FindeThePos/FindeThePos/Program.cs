// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace FindeThePos
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter number of lines: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                FindthPosOfN. FindPositions(line);
            }
        }

    }
}