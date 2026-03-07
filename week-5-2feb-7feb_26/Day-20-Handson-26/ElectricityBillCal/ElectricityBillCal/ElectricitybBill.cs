using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityBillCal
{
    internal class ElectricitybBill
    {
        public static int BillCal(string inp)
        {
            string num = "";
            foreach(char c in inp)
            {
                if (char.IsDigit(c))
                {
                    num += c;
                }
            }
            return Convert.ToInt32(num);

        }
        
    }
}
