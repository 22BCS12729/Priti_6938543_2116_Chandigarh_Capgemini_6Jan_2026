using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveVowel
{
    internal class RemoveVowelConConsec
    {
        static void Main()
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            string vowels = "aeiou";

            // Collect consonants from word2
            HashSet<char> commonConsonants = new HashSet<char>();
            foreach (char ch in word2.ToLower())
            {
                if (char.IsLetter(ch) && !vowels.Contains(ch))
                {
                    commonConsonants.Add(ch);
                }
            }

            // Remove common consonants from word1
            StringBuilder temp = new StringBuilder();
            foreach (char ch in word1)
            {
                char lower = char.ToLower(ch);

                if (vowels.Contains(lower) || !commonConsonants.Contains(lower))
                {
                    temp.Append(ch);
                }
            }

            // Remove consecutive duplicates
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                if (i == 0 || temp[i] != temp[i - 1])
                {
                    result.Append(temp[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

