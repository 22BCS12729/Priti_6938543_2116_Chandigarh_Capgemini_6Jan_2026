using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] input1 = new int[n];

        for (int i = 0; i < n; i++)
        {
            input1[i] = int.Parse(Console.ReadLine());
        }

        int result = UserProgramCode.diffIntArray(input1);

        Console.WriteLine(result);
    }
}
