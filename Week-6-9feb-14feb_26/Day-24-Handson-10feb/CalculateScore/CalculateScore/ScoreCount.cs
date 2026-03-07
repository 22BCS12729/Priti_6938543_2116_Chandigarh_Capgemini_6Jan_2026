using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateScore
{
    internal class ScoreCount
    {
       public  static int CalculateScore(int[] arr)
        {
            int score = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int sum = arr[i] + arr[j] + arr[k];
                        int product = arr[i] * arr[j] * arr[k];

                        if (sum % 2 != 0 && product % 2 == 0)
                            score += 10;
                    }
                }
            }

            return score;
        }
    }
}

