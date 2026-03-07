using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ProductDig
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the Elements");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            if (n % 3 == 0 || n % 5 == 0)
            {
                Console.WriteLine(-2);
                return;
            }
            int temp = n;
            int prd = 1;
            while (temp > 0)
            {
                int digit = temp % 10;
                prd *= digit;
                temp /= 10;
            }
            if (prd % 3 == 0 || prd % 5 == 0)
            {
                Console.WriteLine(1);
            }

        }
    }
}
