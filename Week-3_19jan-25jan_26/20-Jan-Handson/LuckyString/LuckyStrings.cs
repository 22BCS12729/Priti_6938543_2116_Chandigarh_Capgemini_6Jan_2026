using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyString
{
    internal class LuckyStrings
    {
        public static string IsLuckyStrings(int n, string s)
        {
            if (n > s.Length)
                return "Invalid";

            int req = n / 2;
            int cnt = 1;

            for(int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1] && (s[i]== 'P' || s[i] == 'S' || s[i] == 'G'))
                {
                    cnt++;
                    if (cnt >= req)
                        return "Yes";
                }
                else
                {
                    cnt = 1;
                }
            }
            return "No";
        }
    }
}
