using System;
using System.Collections.Generic;
using System.Text;

namespace CountCharRep
{
    internal class RemoveDup
    {
        public static string RemoveDuplicates(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (!sb.ToString().Contains(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
