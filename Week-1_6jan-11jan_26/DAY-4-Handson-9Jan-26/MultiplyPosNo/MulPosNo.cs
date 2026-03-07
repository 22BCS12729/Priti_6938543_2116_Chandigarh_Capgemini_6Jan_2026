using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplyPosNo
{
    internal class MulPosNo
    {
        static void Main()
        {
            //Console.WriteLine("Enter the size-");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("-2");
                return;
            }
            int prod = 1;
            bool found = false;
           // Console.WriteLine("Enter the Array Elements");
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    prod *= x;
                    found = true;
                }
            }
            Console.WriteLine(found ? prod : 0);
        }
    }
}
