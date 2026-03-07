using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement
{
    public class Salary
    {
        public Dictionary<string,int>emp=new Dictionary<string, int>(); 

        public Salary()
        {
            emp.Add("Manager", 50000);
            emp.Add("Developer", 40000);
            emp.Add("Tester", 30000);
            emp.Add("HR", 25000);
        }
        public int totalSalary()
        {
            int total = 0;
            foreach (var item in emp)
            {
                total += item.Value;
            }
            return total;
        }
        public string getSalary(string designation)
        {
            if (emp.ContainsKey(designation))
            {
                return "Salary of " + designation + " is " + emp[designation];
            }
            else
            {
                return "Designation not found";
            }
        }
        public void updateSalary(string designation, int newSalary)
        {
            if (emp.ContainsKey(designation))
            {
                emp[designation] = newSalary;
                Console.WriteLine("Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Designation not found.");
            }
        }
    }
}
