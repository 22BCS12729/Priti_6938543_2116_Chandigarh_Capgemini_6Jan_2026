// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace GetDonation
{
    internal class Program
    {
            static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                string[] input1 = new string[n];

                for (int i = 0; i < n; i++)
                {
                    input1[i] = Console.ReadLine();
                }

                int input2 = int.Parse(Console.ReadLine());

                int result = Donation.getDonation(input1, input2);
                Console.WriteLine(result);
            }
        }
    }


