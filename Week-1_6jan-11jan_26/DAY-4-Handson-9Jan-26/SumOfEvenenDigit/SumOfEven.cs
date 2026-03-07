using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfEvenenDigit
{
    internal class SumOfEven
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            if (n > 32767)
            {
                Console.WriteLine(-1);
                return;
            }
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
