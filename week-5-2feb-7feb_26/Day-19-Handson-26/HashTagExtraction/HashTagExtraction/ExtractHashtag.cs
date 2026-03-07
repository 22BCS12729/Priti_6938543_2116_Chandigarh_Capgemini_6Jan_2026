using System;
using System.Collections.Generic;
using System.Text;

namespace HashTagExtraction
{
    internal class ExtractHashtag
    {
        public static void Extract(string t)
        {
            string[] w = t.Split(' ');

            foreach (string s in w)
            {
                if (IsValidHashtag(s))
                {
                    Console.WriteLine(w);
                }
            }
        }
        static bool IsValidHashtag(string wd)
        {
            if (wd.Length < 2)
            {
                return false;

            }
            if (wd[0] != '#')
                return false;

            for(int i=1;i<wd.Length; i++)
            {
                if (!char.IsLetterOrDigit(wd[i]))
                    return false;
            }
            return true;
        }
    }
}
