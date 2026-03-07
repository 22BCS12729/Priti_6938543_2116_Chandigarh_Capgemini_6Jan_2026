using System;
using System.Collections.Generic;

public class UserProgramCode
{
    public static List<int> GetElements(List<int> input1, int input2)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < input1.Count; i++)
        {
            if (input1[i] < input2)
            {
                result.Add(input1[i]);
            }
        }

        if (result.Count == 0)
        {
            result.Add(-1);
            return result;
        }

        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = i + 1; j < result.Count; j++)
            {
                if (result[i] < result[j])
                {
                    int temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }
}
