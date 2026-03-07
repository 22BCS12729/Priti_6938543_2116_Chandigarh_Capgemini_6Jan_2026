using System;
using System.Collections.Generic;
using System.Text;

namespace LengthOfLongestPal
{
    internal class LenOfLongPal
    {
       public  static int LongestPalindrome(string s)
        {
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                max = Math.Max(max, Expand(s, i, i));
                max = Math.Max(max, Expand(s, i, i + 1));
            }

            return max;
        }

        static int Expand(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}

