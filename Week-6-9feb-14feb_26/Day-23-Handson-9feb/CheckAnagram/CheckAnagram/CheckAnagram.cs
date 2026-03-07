using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAnagram
{
    internal class CheckAnagram
    {
       public static bool AreAllAnagrams(string[] words)
        {
            if (words.Length == 0)
                return true;

            string first = SortWord(words[0].Trim());

            foreach (string word in words)
            {
                if (SortWord(word.Trim()) != first)
                    return false;
            }

            return true;
        }

        static string SortWord(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}

