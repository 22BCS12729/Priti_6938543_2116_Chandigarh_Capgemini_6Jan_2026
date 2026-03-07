// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDesignation
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] inp1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                inp1[i] = Console.ReadLine();
            }

            string inp2 = Console.ReadLine();

            string[] res= Emp_Des.getEmp(inp1, inp2);

            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
        }
    }
}

