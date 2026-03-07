using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryToDec
{
    internal class BinToDec
    {
       public static int BinaryToDecimal(string bin)
        {
            if (bin.Length > 5)
                return -2;

            int decimalValue = 0;
            int power = 1;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] != '0' && bin[i] != '1')
                    return -1;

                decimalValue += (bin[i] - '0') * power;
                power *= 2;
            }

            return decimalValue;
        }

    }
}
