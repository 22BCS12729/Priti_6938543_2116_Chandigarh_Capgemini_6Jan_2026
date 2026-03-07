// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityBillCal
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the meter reading");
            string inp1 = Console.ReadLine();

            Console.WriteLine("Enter the meter Reading");
            string inp2= Console.ReadLine();

            Console.WriteLine("Enter the rate");
            int r=Convert.ToInt32(Console.ReadLine());

            int r1 = ElectricitybBill.BillCal(inp1);
            int r2= ElectricitybBill.BillCal(inp2);
            int res=Math.Abs(r1-r2);
            int rate = res * r;

            Console.WriteLine(rate);
        }
    }
}

