using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryStory
{
    internal class SalCal
    {
        public static int CalculateSavings(int salary, int days)
        {
            if (salary > 9000)
                return -1;
            if (salary < 0)
                return -3;
            if (days < 0)
                return -4;

            int totalSalary = salary;

            if (days == 31)
                totalSalary += 500;

            int foodExpense = totalSalary * 50 / 100;
            int travelExpense = totalSalary * 20 / 100;

            int savings = totalSalary - (foodExpense + travelExpense);
            return savings;
        }
    }
}

