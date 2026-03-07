// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace SumLargetsNoRange
{
    internal class programs
    {
        static void Main()
        {
            int n=Convert.ToInt32(Console.ReadLine());

            int[] inp1=new int[n];
            for(int i = 0; i < n; i++)
            {
                inp1[i]=Convert.ToInt32(Console.ReadLine());
            }
            int res = SumOflargestNo.LargestNo(inp1);
            Console.WriteLine(res);
        }
    }
}

