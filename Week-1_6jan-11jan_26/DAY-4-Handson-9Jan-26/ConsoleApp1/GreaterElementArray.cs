using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class GreaterElementArray
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the element:-");
            int n=int.Parse(Console.ReadLine());

            if (n < 0)
            {
                
                Console.WriteLine(-2);
                return;
            }

            int[]a1=new int[n];
            int[]a2=new int[n];
            int[]out1=new int[n];
            
            for (int i = 0; i < n; i++)
            {
                a1[i]=int.Parse(Console.ReadLine());
                if (a1[i] < 0)
                {
                    out1[0] = -1;
                    Console.WriteLine(out1[0]);
                    return;
                }
            }
            for (int i = 0; i < n; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
                if (a2[i] < 0)
                {
                    out1[0] = -1;
                    Console.WriteLine(out1[0]);
                    return;
                }
            }
            for(int i = 0; i < n; i++)
            {
               
                out1[i] = Math.Max(a1[i], a2[i]);
            }
            Console.WriteLine("The output of the array:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(out1[i]);
            }
           
        }
        
      
    }
}
