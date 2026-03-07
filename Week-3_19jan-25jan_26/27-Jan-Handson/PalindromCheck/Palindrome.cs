using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromCheck
{
    internal class Palindrome
    {
        public static bool IsPalindrom(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
