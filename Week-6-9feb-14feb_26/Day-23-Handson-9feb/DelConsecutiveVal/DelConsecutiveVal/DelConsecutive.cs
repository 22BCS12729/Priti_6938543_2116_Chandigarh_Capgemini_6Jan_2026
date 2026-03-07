using System;
using System.Collections.Generic;
using System.Text;

namespace DelConsecutiveVal
{
    internal class DelConsecutive
    {
       public  static int DeleteVowelPairs(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (IsVowel(s[i]) && IsVowel(s[i + 1]))
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

        static bool IsVowel(char c)
        {
            return "aeiouAEIOU".Contains(c);
        }
    }
}

