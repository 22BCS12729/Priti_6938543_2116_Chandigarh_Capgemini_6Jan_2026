// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Text;

namespace CheckVotingElg
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckVotingEligibility.IsEligible(age)
                ? "Eligible to vote"
                : "Not eligible to vote");
        }
    }

}
}
