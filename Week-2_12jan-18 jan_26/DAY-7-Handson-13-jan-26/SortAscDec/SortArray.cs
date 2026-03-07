using System;
using System.Collections.Generic;
using System.Text;

namespace SortAscDec
{
    internal class SortArray
    {
        
           
           public static void AverageDivisibleBy5()
            {
                Console.WriteLine("Enter the size of array:");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine(-1);
                    return;
                }

                int[] arr = new int[n];
                int sum = 0, count = 0;

                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());

                    if (arr[i] % 5 == 0)
                    {
                        sum += arr[i];
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    double avg = (double)sum / count;
                    Console.WriteLine("Average of numbers divisible by 5 = " + avg);
                }
            }

            
            
        }
    }


