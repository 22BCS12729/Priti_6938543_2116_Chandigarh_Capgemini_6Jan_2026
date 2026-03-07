using System;
abstract class Computer
{
    protected string type;
    protected string model;
    protected string cpu;
    protected bool isTurnedOn = false;

    public Computer(string type, string model, string cpu)
    {
        this.type = type;
        this.model = model;
        this.cpu = cpu;
    }

    public string GetComputerType()
    {
        return type;
    }

    public string GetComputerModel()
    {
        return model;
    }

    public string GetComputerCpu()
    {
        return cpu;
    }

    public bool GetComputerStatus()
    {
        return isTurnedOn;
    }

    public void SwitchComputerStatus()
    {
        isTurnedOn = !isTurnedOn;
    }
}

class PersonalComputer : Computer
{
    public PersonalComputer(string model, string cpu)
        : base("Personal", model, cpu)
    {
    }
}

class ServerComputer : Computer
{
    public ServerComputer(string model, string cpu)
        : base("Server", model, cpu)
    {
    }
}

class Program
{
    static void Main()
    {
        // Personal Computer
        var pcInput = Console.ReadLine().Split(' ');
        Computer pc = new PersonalComputer(pcInput[0], pcInput[1]);

        Console.WriteLine($"PersonalComputer info: Type - {pc.GetComputerType()}, Model - {pc.GetComputerModel()}, Cpu - {pc.GetComputerCpu()}");

        Console.WriteLine($"{pc.GetComputerModel()} is {(pc.GetComputerStatus() ? "On" : "Off")}");

        Console.WriteLine("Switching");
        pc.SwitchComputerStatus();
        Console.WriteLine($"{pc.GetComputerModel()} is {(pc.GetComputerStatus() ? "On" : "Off")}");

        Console.WriteLine("Switching");
        pc.SwitchComputerStatus();
        Console.WriteLine($"{pc.GetComputerModel()} is {(pc.GetComputerStatus() ? "On" : "Off")}");


        // Server Computer
        var serverInput = Console.ReadLine().Split(' ');
        Computer server = new ServerComputer(serverInput[0], serverInput[1]);

        Console.WriteLine($"ServerComputer info: Type - {server.GetComputerType()}, Model - {server.GetComputerModel()}, Cpu - {server.GetComputerCpu()}");

        Console.WriteLine($"{server.GetComputerModel()} is {(server.GetComputerStatus() ? "On" : "Off")}");

        Console.WriteLine("Switching");
        server.SwitchComputerStatus();
        Console.WriteLine($"{server.GetComputerModel()} is {(server.GetComputerStatus() ? "On" : "Off")}");

        Console.WriteLine("Switching");
        server.SwitchComputerStatus();
        Console.WriteLine($"{server.GetComputerModel()} is {(server.GetComputerStatus() ? "On" : "Off")}");
    }
}