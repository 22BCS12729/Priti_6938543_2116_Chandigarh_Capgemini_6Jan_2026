using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveLastOccurence
{
    internal class RemLasOcu
    {
        public static string RemoveLast(string str, string word)
        {
            int index = str.LastIndexOf(word);
            if (index >= 0)
                str = str.Remove(index, word.Length);

            return str;
        }
    }
}

