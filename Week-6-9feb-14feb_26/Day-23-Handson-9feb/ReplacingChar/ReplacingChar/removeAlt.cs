using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveAlternateChar
{
    internal class removeAlt
    {
        public static string DelAlt(string s)
        {
            string res = " ";

            for (int i = 0; i < s.Length; i += 2)
            {
                res += s[i];
            }
            return res;
        }
    }
}
