// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceNumberUpdate
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the invoic no. ");
            string inv=Console.ReadLine();
            Console.WriteLine("Enter the INcrement val");
            int  inc=Convert.ToInt32(Console.ReadLine());
            string res = InvoiceUpdate.Invoice(inv, inc);
            Console.WriteLine(res);
        }
    }
}
