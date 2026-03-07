using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    internal class ReverseStrings
    {
        public static string ReverseWords(string s)
        {
            string result = "";
            string word = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    word = s[i] + word;
                }
                else
                {
                    result += word + " ";
                    word = "";
                }
            }
            result += word;
            return result;
        }
    }
}
