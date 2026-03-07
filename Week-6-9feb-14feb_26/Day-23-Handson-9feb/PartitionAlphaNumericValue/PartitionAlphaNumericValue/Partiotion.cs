using System;
using System.Collections.Generic;
using System.Text;

namespace PartitionAlphaNumericValue
{
    internal class Partiotion
    {
       public  static void PartitionString(string str)
        {
            string left = "";
            string right = str;

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    left += c;
            }

            Console.WriteLine("Left: " + left);
            Console.WriteLine("Right: " + right);
        }
    }
}

