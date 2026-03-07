using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicates
{
    internal class RemDuplicates
    {
        public static string RemoveDuplicates(string s)
        {
            Stack<char>st=new Stack<char>();
            foreach(char ch in s)
            {
                if(st.Count>0&&st.Peek() == ch)
                {
                    st.Pop();
                }
                else
                {
                    st.Push(ch);
                }
            }
            char[]res=st.ToArray();
            Array.Reverse(res);
            return new string(res);
        }
    }
}
