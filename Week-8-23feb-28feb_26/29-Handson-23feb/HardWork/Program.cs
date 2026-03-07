using EmployeeBonusSystem;

namespace HardWork
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Employee emp = new Employee
                {
                    name = "Krishna",
                    projectName = "Alpha",
                    workingHrs = 120
                };

                Console.WriteLine(emp.checkName());
                Console.WriteLine(emp.setBonus());

                Console.ReadLine();
            }
        }
    }