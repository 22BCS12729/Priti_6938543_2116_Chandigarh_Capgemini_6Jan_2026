using System;
using System.Collections.Generic;
using System.Text;

namespace CheckNumericValue
{
    internal class CheckValue
    {
        public static int CheckNumericArray(string[] arr)
        {
            foreach (string s in arr)
            {
                if (!double.TryParse(s, out _))
                    return -1;
            }
            return 1;
        }
    }
}
