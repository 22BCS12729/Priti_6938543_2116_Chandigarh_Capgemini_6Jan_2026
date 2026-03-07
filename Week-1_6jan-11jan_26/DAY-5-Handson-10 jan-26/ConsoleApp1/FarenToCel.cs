using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class FarenToCel
    {
        static void Main()
        {
            Console.WriteLine("Enter Fahrenheit value:");
            int f = int.Parse(Console.ReadLine());

            if (f < 0)
            {
                Console.WriteLine(-1);
                return;
            }

            int c = (f - 32) * 5 / 9;
            Console.WriteLine(c);
        }
    }
}