using System;
using System.Collections.Generic;
using System.Text;

namespace CountNoOfValidWords
{
    internal class CountWords
    {
        public static int CountValidWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            int count = 0;

            foreach (string word in words)
            {
                if (IsValidWord(word))
                    count++;
            }

            return count;
        }
        static bool IsValidWord(string word)
        {
            if (word.Length <= 2)
                return false;

            bool hasVowel = false;
            bool hasConsonant = false;

            foreach (char ch in word)
            {
                if (!char.IsLetterOrDigit(ch))
                    return false;

                if (char.IsLetter(ch))
                {
                    char lower = char.ToLower(ch);

                    if ("aeiou".Contains(lower))
                        hasVowel = true;
                    else
                        hasConsonant = true;
                }
            }
            return hasVowel && hasConsonant;
        }
    }

}

