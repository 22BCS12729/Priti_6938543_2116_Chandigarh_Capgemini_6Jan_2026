using System;
using System.Collections.Generic;
using System.Text;

namespace RepFirstOccu
{
    internal class RepFirstOccurence
    {
        public static string ReplaceFirst(string str, char oldChar, char newChar)
        {
            int index = str.IndexOf(oldChar);
            if (index >= 0)
            {
                char[] arr = str.ToCharArray();
                arr[index] = newChar;
                return new string(arr);
            }
            return str;
        }
    }
}

