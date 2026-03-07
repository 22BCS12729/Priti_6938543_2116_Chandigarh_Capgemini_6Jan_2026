// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordValidate
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter password:");
            string pwd = Console.ReadLine();

            Console.WriteLine(PassValidate.ValidatePassword(pwd));
        }
    }
}
