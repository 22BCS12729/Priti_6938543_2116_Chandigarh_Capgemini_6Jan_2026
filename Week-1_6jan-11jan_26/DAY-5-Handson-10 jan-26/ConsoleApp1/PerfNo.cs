using System;

namespace ConsoleApp1
{
    internal class PerfNo
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("print- "+ -2);
                return;
            }
            if (n == 0 || n == 1)
            {
                Console.WriteLine("Print=" +-1);
                return;
            }

            int sum = 0;

            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
                Console.WriteLine("Perfect no. Give output= "+ 1);
            else
                Console.WriteLine("Not Perfect no.Give output= "+ -1);
        }
    }
}
