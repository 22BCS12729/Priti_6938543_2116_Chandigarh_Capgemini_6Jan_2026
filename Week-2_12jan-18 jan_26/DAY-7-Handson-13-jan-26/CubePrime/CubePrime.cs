using System;
using System.Collections.Generic;
using System.Text;

namespace CubePrime
{
    internal class CubePrime
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            if (n < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            if (n > 32767)
            {
                Console.WriteLine(-2);
                return;
            }
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sum = sum + (i * i * i);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
