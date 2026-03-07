namespace EmployeeSalaryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary();

            Console.WriteLine("Total Salary: " + s.totalSalary());

            Console.WriteLine(s.getSalary("Manager"));

            s.updateSalary("Developer", 45000);

            Console.WriteLine(s.getSalary("Developer"));

            Console.ReadLine();
        }
    }
}