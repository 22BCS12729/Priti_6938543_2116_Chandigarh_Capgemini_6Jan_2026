// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter input1:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter input2:");
        string input2 = Console.ReadLine();

        Console.WriteLine("Enter input3:");
        string input3 = Console.ReadLine();

        Console.WriteLine(CheckOrder(input1, input2, input3));
    }

    static int CheckOrder(string input1, string input2, string input3)
    {
        string pattern = Regex.Escape(input2) + ".*" + Regex.Escape(input3);
        return Regex.IsMatch(input1, pattern) ? 1 : -1;
    }
}
