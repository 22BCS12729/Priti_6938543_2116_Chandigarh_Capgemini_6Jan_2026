using System;
using System.Collections.Generic;
using System.Text;

namespace CountRepeatProg
{
    internal class CountRepeat
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 3 };
            int size = 5;
            int search = 2;
            int cnt = 0;
            if (size < 0)
            {
                Console.WriteLine(-2);
                return;
            }
            if (search < 0)
            {
                Console.WriteLine(-3);
                return;
            }
            for(int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }

                if (arr[i] == search)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
