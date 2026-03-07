using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubString
{
    internal class LongestSubStringLength
    {
        public static int Longsub(string s)
        {
            int[] f = new int[256];
            int l = 0;
            int maxLen = 0;

            for (int r = 0; r < s.Length; r++)
            {
                f[s[r]]++;
                while (f[s[r]] > 1)
                {
                    f[s[l]]--;
                    l++;
                }
                maxLen = Math.Max(maxLen, r - l + 1);
            }
            return maxLen;
        }
    }
}
