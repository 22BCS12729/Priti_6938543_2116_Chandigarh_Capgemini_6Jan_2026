using System;
using System.Collections.Generic;
using System.Text;

namespace MaxDeletion
{
    internal class MaxDel
    {
        public static int Maxdel(string s)
        {
            int cnt = 0;
            int del = 0;
            for (int i = 1; i < s.Length; i++)
            {

                if (s[i] == s[i - 1])
                {
                    cnt++;
                }
                else
                {
                    del += cnt / 2;
                    cnt = 1;
                }
            }
            del += cnt / 2;
            return del;
        }
    }
}
