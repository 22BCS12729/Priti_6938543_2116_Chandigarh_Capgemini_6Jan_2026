using System;
using System.Collections.Generic;
using System.Text;

namespace SortSeperatedWord
{
    internal class SotSepWord
    {
        public static string SortWords(string input)
        {
            string[] words = input.Split('|');
            Array.Sort(words);
            return string.Join("|", words);
        }
    }

}

