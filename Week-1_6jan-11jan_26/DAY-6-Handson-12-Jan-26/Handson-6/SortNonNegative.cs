using System;
using System.Collections.Generic;
using System.Text;

namespace Handson_6
{
    internal class SortNonNegative
    {
        static void Main()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            if (size < 0)
            {
                Console.WriteLine(-1);
                return;
            }

            int[] arr = new int[size];
            Console.WriteLine("Enter the array Elements-");

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }

            int[] res= new int[count];
            int index = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 0)
                {
                    res[index++] = arr[i];
                }
            }

            Array.Sort(res);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write( res[i]+" " );
            }
        }
    }
}