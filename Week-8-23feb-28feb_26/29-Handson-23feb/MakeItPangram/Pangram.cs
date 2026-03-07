using System;
using System.Collections.Generic;
using System.Linq;

namespace PangramValidation
{
    public class Pangram
    {
        public int MinimumAlphabet(string input)
        {
            input = input.ToLower();

            HashSet<char> letters = new HashSet<char>();

            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                {
                    letters.Add(c);
                }
            }

            return 26 - letters.Count;
        }
    }
}
