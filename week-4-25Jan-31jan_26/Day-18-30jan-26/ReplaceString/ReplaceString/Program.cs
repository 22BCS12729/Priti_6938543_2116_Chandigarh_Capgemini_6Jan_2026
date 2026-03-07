// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceString
{
    internal class Program
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            int input2 = int.Parse(Console.ReadLine());
            char input3 = Convert.ToChar(Console.ReadLine());

            string result =StringReplace.replaceString(input1, input2, input3);

            if (result == "-1")
                Console.WriteLine("Invalid String");
            else if (result == "-2")
                Console.WriteLine("Number not positive");
            else if (result == "-3")
                Console.WriteLine("Character not a special character");
            else
                Console.WriteLine(result);
        }
    }
}


