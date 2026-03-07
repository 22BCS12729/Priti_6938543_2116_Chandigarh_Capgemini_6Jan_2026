using System;
using System.Collections.Generic;
using System.Text;

namespace InsertSubstring
{
    internal class InsertSub
    {
        public static string InsertAt(string str, string sub, int pos)
        {
            return str.Insert(pos, sub);
        }
    }
}

