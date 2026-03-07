// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Text;

namespace StrongPaasValidation
{
    internal class Program
    {
        static void Main()
        {
         
            string password = Console.ReadLine();
            if (StrongPass.strongpass(password))
            {
                Console.WriteLine("Strong");
            }
            else
            {
                Console.WriteLine("Weak");
            }
        }

    }
}

