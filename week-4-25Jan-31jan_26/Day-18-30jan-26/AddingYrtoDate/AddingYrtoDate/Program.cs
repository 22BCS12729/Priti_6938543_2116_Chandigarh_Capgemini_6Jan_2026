using System;
using System.Collections.Generic;
using System.Text;

namespace AddingYrtoDate
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(AddYears("12/05/2024", 2));
            Console.WriteLine(AddYears("12-05-2024", 2));
            Console.WriteLine(AddYears("12/05/2024", -1));
        }
    }
}
