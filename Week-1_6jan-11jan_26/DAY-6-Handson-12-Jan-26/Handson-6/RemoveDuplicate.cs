using System;
using System.Collections.Generic;
using System.Text;

namespace Handson_6
{
    internal class RemoveRepeatedElements
    {
            static void Main()
            {
                Console.Write("Enter array size: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];
                 Console.WriteLine("Enter the Array Elements-");

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int[] result = RemoveDuplicates(arr);

                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }

            static int[] RemoveDuplicates(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                        
                    return new int[] { -1 };
                }

                int[] temp = new int[arr.Length];
                int index = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    bool found = false;

                    for (int j = 0; j < index; j++)
                    {
                        if (arr[i] == temp[j])
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        temp[index] = arr[i];
                        index++;
                    }
                }

                int[] result = new int[index];
                for (int i = 0; i < index; i++)
                {
                    result[i] = temp[i];
                }

                return result;
            }
        }
    }
