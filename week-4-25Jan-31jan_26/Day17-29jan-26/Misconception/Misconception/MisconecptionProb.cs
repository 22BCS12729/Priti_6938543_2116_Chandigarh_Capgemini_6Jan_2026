using System;
using System.Collections.Generic;
using System.Text;

namespace Misconception
{
    internal class MisconecptionProb
    {
        public static string Check(string s)
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && s[i] == 'i' && s[i + 1] == 's' &&
                    (i == 0 || !char.IsLetter(s[i - 1]) &&
                    (i + 2 == s.Length || !char.IsLetter(s[i + 2]))))
                {
                    res.Append("is not");
                    i++;
                }
                else
                {
                    res.Append(s[i]);
                }

            }
            return res.ToString();
        }
    }
}