using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmployeeDesignation
{
    internal class Emp_Des
    {

        static bool Isvalid(string s)
        {
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                        return false;
                }
                return true;
            }

        }

        public static string[] getEmp(string[] inp1, string inp2)
        {
            if (!Isvalid(inp2))
                return new string[] { "Invalid Inpuut" };

            foreach (string s in inp1)
            {
                if (!Isvalid(s))
                    return new string[] { "Invalid Input" };
            }

            List<string> emp = new List<string>();
            bool sameDes = true;

            for (int i = 0; i < inp1.Length; i += 2)
            {
                string empname = inp1[i];
                string des = inp1[i + 1];

                if (!des.Equals(inp2, StringComparison.OrdinalIgnoreCase))
                {
                    sameDes = false;
                }

                if (des.Equals(inp2, StringComparison.OrdinalIgnoreCase))
                {
                    emp.Add(empname);
                }

            }

            if (emp.Count == 0)
            {
                return new string[] { $"No employee for {inp2}desiignation" };
            }

            if (sameDes)
            {
                return new string[] { $"All employees belong to same{inp2}designation" };
            }
            return emp.ToArray();
        }
    }
}
