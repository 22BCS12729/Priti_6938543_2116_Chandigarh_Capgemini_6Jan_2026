using System;

namespace EmployeeBonusSystem
{
    public class Employee
    {
        public string name { get; set; }
        public string projectName { get; set; }
        public int workingHrs { get; set; }
        public int bonus { get; set; }

        public string setBonus()
        {
            if (projectName == "Alpha" && workingHrs >= 100)
                bonus = 10000;
            else if (projectName == "Beta" && workingHrs >= 80)
                bonus = 8000;
            else if (workingHrs >= 50)
                bonus = 5000;
            else
                bonus = 0;

            return "Bonus calculated: " + bonus;
        }

        public string checkName()
        {
            if (!string.IsNullOrEmpty(name))
                return "Employee Name: " + name;
            else
                return "Invalid Employee Name";
        }
    }
}
