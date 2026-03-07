using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulationSystem
{
    public class StringPlay
    {
        public int convert { get; set; }
        public int max { get; set; }
    }

    public class StringMethods
    {
        public int ConvertToInt(StringPlay sp, string input)
        {
            sp.convert = int.Parse(input);
            return sp.convert;
        }

        public int GetMax(StringPlay sp, string input, char ch)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == ch)
                {
                    count++;
                }
            }

            sp.max = count;
            return sp.max;
        }
    }
}