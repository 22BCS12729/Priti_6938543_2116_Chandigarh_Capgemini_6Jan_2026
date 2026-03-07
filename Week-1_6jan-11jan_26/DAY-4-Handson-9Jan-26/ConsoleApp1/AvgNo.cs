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
            bool hasNegative = false;

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    out1 = -1;
                    hasNegative = true;
                    break;
                }

                if (arr[i] % 2 == 0)
                    Esum += arr[i];
                else
                    Osum += arr[i];
            }

            if (!hasNegative)
            {
                avg = (Esum + Osum) / 2;
                out1 = avg;
            }
        }

        Console.WriteLine("The output1 variable = " + out1);
    }
}
