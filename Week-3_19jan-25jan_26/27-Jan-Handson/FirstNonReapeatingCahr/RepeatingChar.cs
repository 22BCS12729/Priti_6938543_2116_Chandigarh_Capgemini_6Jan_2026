using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FirstNonReapeatingCahr
{
    internal class RepeatingChar
    {
        public static char RepChar(string s)
        {
            Hashtable map=new Hashtable();
            foreach(char c in s) {
                if (map.ContainsKey(c))
                    map[c] = (int)map[c] + 1;
                else
                    map[c] = 1;
        }

            int left = 0;
            int right = s.Length - 1;


            while (left <= right)
            {
                if ((int)map[s[left]] == 1)
                    return s[left];

                left++;
            }
            return '\0';
        }
    }
}
