using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCU
{
    internal class FactNo
    {
        static void Main()
        {
            Console.Write("Enter the factorial no:-");
            int num;
            int op1 = 1;
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                op1 = -1;
            }
            else if (num > 7)
            {
                op1 = -2;
            }
            else
            {

                for (int i = 1; i < num; i++)
                {
                    op1 *= i;
                }


            }
            Console.Write("The variable output1 is:-" + op1);

        }
    }
}
