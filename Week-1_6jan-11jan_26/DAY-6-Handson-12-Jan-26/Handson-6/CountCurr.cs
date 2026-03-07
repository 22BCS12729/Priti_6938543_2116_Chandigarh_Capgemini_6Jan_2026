using System;
using System.Collections.Generic;
using System.Text;

namespace Handson_6
{
    internal class CountCurr
    {
        static void Main()
        {
            Console.WriteLine("Enter amount:");
            int amnt = int.Parse(Console.ReadLine());
            if (amnt < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            int cnt = 0;
            cnt += amnt / 500;
            amnt %= 500;
            cnt += amnt/ 100;
            amnt %= 100;

            cnt += amnt/ 50;
            amnt%= 50;

            cnt+= amnt/ 10;
            amnt%= 10;

            cnt +=amnt;
            Console.WriteLine("Output ="+ cnt);
        }

    }
}
