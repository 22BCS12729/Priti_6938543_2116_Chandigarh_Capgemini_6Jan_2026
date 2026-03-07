using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveARrray
{
    internal class RemDuplicate
    {
            public static int[] RemoveDuplicateElements(int[] input, int size)
            {
                if (size < 0)
                {
                    return new int[] { -2 };
                }

                for (int i = 0; i < size; i++)
                {
                    if (input[i] < 0)
                    {
                        return new int[] { -1 };
                    }
                }

                int[] temp = new int[size];
                int index = 0;

                for (int i = 0; i < size; i++)
                {
                    bool isDuplicate = false;

                    for (int j = 0; j < index; j++)
                    {
                        if (input[i] == temp[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        temp[index] = input[i];
                        index++;
                    }
                }

                int[] output = new int[index];

                for (int i = 0; i < index; i++)
                {
                    output[i] = temp[i];
                }

                return output;
            }

           
        }
    }


