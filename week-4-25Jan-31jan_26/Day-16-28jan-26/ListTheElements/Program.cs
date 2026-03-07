using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> input1 = new List<int>();

        for (int i = 0; i < n; i++)
        {
            input1.Add(int.Parse(Console.ReadLine()));
        }

        int input2 = int.Parse(Console.ReadLine());

        List<int> output = UserProgramCode.GetElements(input1, input2);

        if (output.Count == 1 && output[0] == -1)
        {
            Console.WriteLine("No element found");
        }
        else
        {
            for (int i = 0; i < output.Count; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
