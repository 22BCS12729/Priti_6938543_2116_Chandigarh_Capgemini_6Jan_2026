using System;
using System.Collections.Generic;
using System.Text;

namespace FormString
{
    internal class Stringform
    {
        public static string formString(string[] input1, int input2)
        {
            foreach (string s in input1)
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                        return "-1";
                }
            }

            string result = "";

            foreach (string s in input1)
            {
                if (input2 <= s.Length)
                    result += s[input2 - 1];
                else
                    result += "$";
            }

            return result;
        }
    }
}

