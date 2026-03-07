using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompression
{
    internal class CompressStr
    {
        public static string Compressstring(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {

                char curr = s[i]; ;
                int cnt = 0;

                while (i < s.Length && s[i] == curr)
                {
                    cnt++;
                    i++;
                }
                sb.Append(curr);
                sb.Append(cnt);
            }
            return sb.ToString();
        }
    }
}
