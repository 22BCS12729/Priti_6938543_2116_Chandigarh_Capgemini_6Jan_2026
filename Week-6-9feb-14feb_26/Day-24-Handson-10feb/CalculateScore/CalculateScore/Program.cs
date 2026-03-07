// See https://aka.ms/new-console-template for more information
.//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateScore
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter array elements (comma-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(','), x => int.Parse(x.Trim()));

            int score = ScoreCount.CalculateScore(arr);
            Console.WriteLine("Final Score: " + score);
        }

    }
}

