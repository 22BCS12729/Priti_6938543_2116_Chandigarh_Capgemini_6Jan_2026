using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ConsoleApp1
{
    internal class AddArrayElements
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
                return;
            }

            int[] input1 = new int[n];
            int[] input2 = new int[n];
            int[] output = new int[n];

            Console.WriteLine("Enter elements of Input1:");
            for (int i = 0; i < n; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            Console.WriteLine("Enter elements of Input2:");
            for (int i = 0; i < n; i++)
            {
                input2[i] = int.Parse(Console.ReadLine());
                if (input2[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            for (int i = 0; i < n; i++)
            {
                output[i] = input1[i] + input2[n - 1 - i];
            }

            Console.WriteLine("Output array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
