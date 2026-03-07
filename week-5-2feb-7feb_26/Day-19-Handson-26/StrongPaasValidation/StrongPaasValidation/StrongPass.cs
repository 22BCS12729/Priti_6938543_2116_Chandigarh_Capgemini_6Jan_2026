using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace StrongPaasValidation
{
    internal class StrongPass
    {
        public static bool strongpass(string p)
        {
            if (p.Length < 8)
            {
                return false;
            }

            bool hasUpper = false;
           bool hasLower = false;
            bool hasDigit = false;
            bool hasspecial = false;

            string specialChar = "@$!*?&";

            foreach(char c in p)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
                else if(specialChar.Contains(c))
                    hasspecial = true;
                      
            }
            return hasUpper && hasLower && hasDigit && hasDigit;
        }
    }
}
