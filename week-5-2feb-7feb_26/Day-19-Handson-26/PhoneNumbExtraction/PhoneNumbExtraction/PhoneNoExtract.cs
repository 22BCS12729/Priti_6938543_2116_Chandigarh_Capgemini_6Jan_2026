using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumbExtraction
{
    internal class PhoneNoExtract
    {


        public static void phone(string t)
        {
            string currno = " ";

            foreach (char ch in t)
            {
                if (char.IsDigit(ch))
                {
                    currno += ch;
                }
                else
                {
                    PrintfValid(currno);
                    currno = "";
                }
            }
            PrintfValid(currno);
        }
        static void PrintfValid(string num)
        {
            if (num.Length == 10)
            {
                Console.WriteLine(num);
            }

        }
    }
}
