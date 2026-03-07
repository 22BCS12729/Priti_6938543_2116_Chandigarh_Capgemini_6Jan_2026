using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToDec
{
    internal class RomToDec
    {
        public static int ConvertToRom(string s)
        {
            Dictionary<char, int> rm = new Dictionary<char, int>()
            {
                { 'I',1},
                { 'V', 5},
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}

            };

            int sum = 0;
            foreach (char c in s) {
                if (!rm.ContainsKey(c)) {
                    return -1;
                }
                sum += rm[c];

            }
            return sum;
        }
    }
}
