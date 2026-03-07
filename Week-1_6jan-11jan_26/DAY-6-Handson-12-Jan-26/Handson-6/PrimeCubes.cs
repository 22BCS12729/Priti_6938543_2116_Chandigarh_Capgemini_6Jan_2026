using System;

namespace Handson_6
{
    internal class PrimeCubes
    {
        static void Main()
        {
            Console.WriteLine("Eter the N PrimeNo.:-");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            if (n > 32676)
            {
                Console.WriteLine(-2);
                return;
            }
            int cnt = 0;
            int num = 2;
            long sum = 0;
            Console.WriteLine("Prime no.used-");
            while (cnt < n)
            {
                bool prime = true;
               // Console.WriteLine("Ennter the elements-");
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(num +" ");
                    sum += (long)num * num * num;
                    cnt++;
                }
                num++;
            }
            Console.WriteLine("The sum is- " +sum);
        }
    }
}
       