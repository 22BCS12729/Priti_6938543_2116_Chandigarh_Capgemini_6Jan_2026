using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DateExtraction
{
    internal class Extraction
    {
            public static void ExtractDates(string s)
            {
                string[] w = s.Split(' ');

                foreach (string word in w)
                {
                    // pass 'word', not 'w'
                    if (IsValidate(word))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            static bool IsValidate(string d)
            {
                if (d.Length != 10)
                    return false;

                if (d[2] != '/' || d[5] != '/')
                    return false;

                for (int i = 0; i < d.Length; i++)
                {
                    if (i == 2 || i == 5)
                        continue;

                    if (!char.IsDigit(d[i]))
                        return false;
                }

                return true;
            }

            static void Main()
            {
                string input = Console.ReadLine();
                ExtractDates(input);
            }
        }
    }

