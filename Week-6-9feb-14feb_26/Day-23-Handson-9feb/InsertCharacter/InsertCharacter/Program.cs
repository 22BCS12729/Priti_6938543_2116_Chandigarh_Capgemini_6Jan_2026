// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace InsertCharacter
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            char ch=Convert.ToChar(Console.ReadLine());
            int pos=Convert.ToInt32(Console.ReadLine());
            string res = InsertSingleChar.InsertingChar(str, ch, pos);
            Console.WriteLine(res);
        }
    }
}

