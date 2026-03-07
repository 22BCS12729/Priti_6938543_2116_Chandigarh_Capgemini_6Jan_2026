using System;
using System.Collections.Generic;
using System.Text;

namespace CountVolwels
{
    internal class CountVowels
    {
        public static int CountVowel(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char ch = char.ToLower(s[i]);

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
