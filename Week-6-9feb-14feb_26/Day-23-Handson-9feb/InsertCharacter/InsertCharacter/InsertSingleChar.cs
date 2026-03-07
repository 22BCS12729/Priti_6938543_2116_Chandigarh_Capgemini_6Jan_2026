using System;
using System.Collections.Generic;
using System.Text;

namespace InsertCharacter
{
    internal class InsertSingleChar
    {
        public static string InsertingChar(string str ,char ch,int pos)
        {
            if (pos < 1 || pos > str.Length + 1)
            {
                Console.WriteLine(-1);
            }
        
            return str.Insert(pos-1,ch.ToString());

        }
    }
}
