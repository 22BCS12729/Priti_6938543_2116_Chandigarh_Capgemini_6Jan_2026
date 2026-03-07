// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace LocationCodeUpdate
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter curre invoice");
            string inv = Console.ReadLine();

            Console.WriteLine("Enter the Location Code");
            string newLoc=Console.ReadLine();

            string res= Location_Update.updateLocation(inv, newLoc);
            Console.WriteLine(res);
        }
    }
}

