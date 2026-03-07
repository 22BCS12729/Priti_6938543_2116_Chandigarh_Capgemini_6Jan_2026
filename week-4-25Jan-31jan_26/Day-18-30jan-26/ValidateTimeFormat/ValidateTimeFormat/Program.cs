// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text.RegularExpressions;

        class TimeValid
        {
            static bool IsValidTime(string time)
            {
                string pattern = @"^(0[1-9]|1[0-2]):[0-5][0-9]\s(am|pm)$";
                return Regex.IsMatch(time, pattern, RegexOptions.IgnoreCase);
            }

            static void Main()
            {
                Console.WriteLine("Enter time (hh:mm am/pm):");
                string time = Console.ReadLine();

                Console.WriteLine(IsValidTime(time)
                    ? "Valid Time"
                    : "Invalid Time");
            }
        }

