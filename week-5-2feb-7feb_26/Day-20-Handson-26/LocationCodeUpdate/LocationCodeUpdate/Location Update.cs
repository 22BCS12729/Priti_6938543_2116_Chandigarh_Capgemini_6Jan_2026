using System;
using System.Collections.Generic;
using System.Text;

namespace LocationCodeUpdate
{
    internal class Location_Update
    {
        public static string updateLocation(string inv,string newLoc)
        {
            string[] p=inv.Split('-');
            p[1] = newLoc;
            return string.Join("-",p);
        }
    }
}
