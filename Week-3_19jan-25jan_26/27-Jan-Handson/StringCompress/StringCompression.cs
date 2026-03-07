using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompress
{
    internal class StringCompression
    {
        public static string Compress(string s)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;
            while (i < s.Length)
            {
                char current = s[i];
                int count = 0;
                while (i < s.Length && s[i] == current)
                {
                    count++;
                    i++;
                }
                result.Append(current);
                result.Append(count);
            }
            return result.ToString();
        }
    }
}

