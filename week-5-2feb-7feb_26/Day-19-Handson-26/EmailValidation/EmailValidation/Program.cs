// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidation
{
    internal class Program
    {
        static void Main()
        {
            string email = Console.ReadLine();

            if (ValidEmail.IsValidEmail(email))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}


