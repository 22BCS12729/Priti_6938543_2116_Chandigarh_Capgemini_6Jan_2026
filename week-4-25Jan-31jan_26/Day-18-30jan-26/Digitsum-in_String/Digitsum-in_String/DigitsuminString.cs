using System;
using System.Collections.Generic;
using System.Text;

namespace Digitsum_in_String
{
    internal class DigitsuminString
    {
        public static int sumOfDigit(string[] input)
        {
            int sum = 0;
            foreach(string s in input)
            {
                foreach(char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        sum += c - '0';
                    }
                    else if (!char.IsLetter(c))
                    {
                        return -1;
                    }
                }
            }
            return sum;
        }
    }
}
