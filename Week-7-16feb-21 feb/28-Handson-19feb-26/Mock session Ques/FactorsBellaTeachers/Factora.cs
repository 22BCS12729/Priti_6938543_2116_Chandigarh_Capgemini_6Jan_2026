using System;
using System.Collections.Generic;
using System.Text;

namespace FactorsBellaTeachers
{
    internal class Factora
    {
        public static void  factor(int inp)
        {
           
            if (inp == 0)
            {
                Console.WriteLine("No Factor");
                return;
            }
            inp = Math.Abs(inp);

            for(int i = 1; i <= inp; i++)
            {
                if(inp % i == 0){
                    if (i == inp)
                        Console.Write(i);
                    Console.Write(i + ",");

                }
            }

        }
    }
}
