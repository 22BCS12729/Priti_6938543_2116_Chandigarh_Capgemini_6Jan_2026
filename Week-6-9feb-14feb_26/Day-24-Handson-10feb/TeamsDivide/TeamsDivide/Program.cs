// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsDivide
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            int[] skills = new int[n];
            Console.WriteLine("Enter skill levels of employees:");
            for (int i = 0; i < n; i++)
            {
                skills[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number of teams: ");
            int t = int.Parse(Console.ReadLine());

            int[] teamSizes = new int[t];
            Console.WriteLine("Enter team sizes:");
            for (int i = 0; i < t; i++)
            {
                teamSizes[i] = int.Parse(Console.ReadLine());
            }

            DivideTeam.DivideTeams(skills, teamSizes);
        }
    }
}