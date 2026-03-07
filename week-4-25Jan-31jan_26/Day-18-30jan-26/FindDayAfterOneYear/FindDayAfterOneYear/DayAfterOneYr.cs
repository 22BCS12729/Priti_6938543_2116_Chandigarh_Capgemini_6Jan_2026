using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FindDayAfterOneYear
{
    internal class DayAfterOneYr
    {
        static string FindDayAfterOneYear(string dateStr)
        {
            DateTime date = DateTime.ParseExact(
                dateStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            return date.AddYears(1).DayOfWeek.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Enter date (dd/MM/yyyy):");
            string date = Console.ReadLine();

            Console.WriteLine("Day after 1 year: " + FindDayAfterOneYear(date));
        }
    }
}
