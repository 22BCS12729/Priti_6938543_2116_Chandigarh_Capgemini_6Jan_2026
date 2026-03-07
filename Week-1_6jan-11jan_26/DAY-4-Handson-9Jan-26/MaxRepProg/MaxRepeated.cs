using System;
using System.Collections.Generic;
using System.Text;

namespace MaxRepProg
{
    internal class MaxRepeated
    {
        static void Main()
        {
            Console.WriteLine("Enter the size");
            int n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];

            Console.WriteLine("Enter the Array elements");
            for(int i = 0; i < n; i++)
            
                arr[i]=int.Parse(Console.ReadLine());

                int maxCount = 0;
                int element = arr[0];


                for(int i = 0; i < n; i++)
                {
                int cnt = 0;
                for(int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        cnt++;
                }

                if (cnt > maxCount)
                {
                    maxCount = cnt;
                    element = arr[i];
                }

                }
            Console.WriteLine("The elemnt repeated is-"+element);
            
        }
    }
}
