using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace InvoiceNumberUpdate
{
    internal class InvoiceUpdate
    {
        public static string Invoice(string inv,int inc)
        {
            Match m = Regex.Match(inv, @"\d+");

            int num = Convert.ToInt32(m.Value);

            num += inc;
            string res = Regex.Replace(inv, @"\d+", num.ToString());
            return res;
        }
    }
}
