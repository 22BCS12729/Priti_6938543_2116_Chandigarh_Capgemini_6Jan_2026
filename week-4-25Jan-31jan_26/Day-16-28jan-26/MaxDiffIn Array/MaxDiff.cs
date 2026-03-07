using System;
using System.Linq;

public class UserProgramCode
{
    public static int diffIntArray(int[] input1)
    {
        int n = input1.Length;

        if (n <= 1 || n > 10)
        {
            return -2;
        }

        foreach (int num in input1)
        {
            if (num < 0)
            {
                return -1;
            }
        }

        if (input1.Length != input1.Distinct().Count())
        {
            return -3;
        }

        int minValue = input1[0];
        int maxDiff = int.MinValue;

        for (int i = 1; i < n; i++)
        {
            int diff = input1[i] - minValue;

            if (diff > maxDiff)
            {
                maxDiff = diff;
            }

            if (input1[i] < minValue)
            {
                minValue = input1[i];
            }
        }

        return maxDiff;
    }
}
