using System;
abstract class Employee
{
    protected string department;
    protected string name;
    protected string location;
    protected bool isOnVacation = false;

    public Employee(string department, string name, string location)
    {
        this.department = department;
        this.name = name;
        this.location = location;
    }

    public string GetDepartment()
    {
        return department;
    }

    public string GetName()
    {
        return name;
    }

    public string GetLocation()
    {
        return location;
    }

    public bool GetStatus()
    {
        return isOnVacation;
    }

    public void SwitchStatus()
    {
        isOnVacation = !isOnVacation;
    }
}

class FinanceEmployee : Employee
{
    public FinanceEmployee(string name, string location)
        : base("Finance", name, location)
    {
    }
}

class MarketingEmployee : Employee
{
    public MarketingEmployee(string name, string location)
        : base("Marketing", name, location)
    {
    }
}

class Program
{
    static void Main()
    {
        // Finance Employee
        var f = Console.ReadLine().Split(' ');
        Employee financeEmployee = new FinanceEmployee(f[0], f[1]);

        Console.WriteLine($"FinanceEmployee info: Department - {financeEmployee.GetDepartment()}, Name - {financeEmployee.GetName()}, Location - {financeEmployee.GetLocation()}");

        Console.WriteLine($"{financeEmployee.GetName()} is {(financeEmployee.GetStatus() ? "on" : "not on")} vacation");

        Console.WriteLine("Switching");
        financeEmployee.SwitchStatus();
        Console.WriteLine($"{financeEmployee.GetName()} is {(financeEmployee.GetStatus() ? "on" : "not on")} vacation");

        Console.WriteLine("Switching");
        financeEmployee.SwitchStatus();
        Console.WriteLine($"{financeEmployee.GetName()} is {(financeEmployee.GetStatus() ? "on" : "not on")} vacation");


        // Marketing Employee
        var m = Console.ReadLine().Split(' ');
        Employee marketingEmployee = new MarketingEmployee(m[0], m[1]);

        Console.WriteLine($"MarketingEmployee info: Department - {marketingEmployee.GetDepartment()}, Name - {marketingEmployee.GetName()}, Location - {marketingEmployee.GetLocation()}");

        Console.WriteLine($"{marketingEmployee.GetName()} is {(marketingEmployee.GetStatus() ? "on" : "not on")} vacation");

        Console.WriteLine("Switching");
        marketingEmployee.SwitchStatus();
        Console.WriteLine($"{marketingEmployee.GetName()} is {(marketingEmployee.GetStatus() ? "on" : "not on")} vacation");

        Console.WriteLine("Switching");
        marketingEmployee.SwitchStatus();
        Console.WriteLine($"{marketingEmployee.GetName()} is {(marketingEmployee.GetStatus() ? "on" : "not on")} vacation");
    }
}