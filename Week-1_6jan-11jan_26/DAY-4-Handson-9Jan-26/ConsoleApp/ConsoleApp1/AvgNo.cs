using System;
using System.Collections.Generic;
using System.Text;

internal class AvgNo
{
    static void Main()
    {
        Console.Write("Enter the Number: ");
        int n;
        int Esum = 0;
        int Osum = 0;
        int out1 = 0;
        int avg;
        n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            out1 = -2;
        }
        else
        {
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int num in arr)
            {
                if (num < 0)
                {
                    out1 = -1;
                    Console.WriteLine("The output1 variable = " + out1);
                    return;
                }

                if (num % 2 == 0)
                    Esum += num;
                else
                    Osum += num;
            }

            avg = (Esum + Osum) / 2;
            out1 = avg;
        }
    Console.WriteLine("The output1 variable = " + out1);
    }
}
