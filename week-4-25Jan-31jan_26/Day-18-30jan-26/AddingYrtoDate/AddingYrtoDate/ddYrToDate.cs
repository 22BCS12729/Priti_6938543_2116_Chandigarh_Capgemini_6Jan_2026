using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AddingYrtoDate
{
    internal class ddYrToDate
    {
       public  static string AddYears(string dateStr, int years)
        {
            if (years < 0)
                return "-2";

            DateTime date;
            if (!DateTime.TryParseExact(
                    dateStr,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out date))
            {
                return "-1";
            }

            return date.AddYears(years).ToString("dd/MM/yyyy");
        }
    }