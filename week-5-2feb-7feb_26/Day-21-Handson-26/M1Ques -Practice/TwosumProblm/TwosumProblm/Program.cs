// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace TwosumProblm
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for(int i = 0; i < n; i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
            }
            int target = int.Parse(Console.ReadLine());

            int[] res = TwoSum.TwoSumprob(nums,target);

           Console.WriteLine(res);
        }
    }

}

