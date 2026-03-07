using System;
using System.Text.RegularExpressions;

interface IBankAccountOperation
{
    void Deposit(decimal d);
    void Withdraw(decimal d);
    decimal ProcessOperation(string message);
}

class BankOperations : IBankAccountOperation
{
    decimal balance = 0;

    public void Deposit(decimal d)
    {
        balance += d;
    }

    public void Withdraw(decimal d)
    {
        if (balance >= d)
            balance -= d;
    }

    public decimal ProcessOperation(string message)
    {
        message = message.ToLower();

        Match m = Regex.Match(message, @"\d+");
        decimal amount = 0;

        if (m.Success)
            amount = Convert.ToDecimal(m.Value);

        if (message.Contains("deposit") || message.Contains("put") || message.Contains("invest") || message.Contains("transfer"))
        {
            Deposit(amount);
        }
        else if (message.Contains("withdraw") || message.Contains("pull"))
        {
            Withdraw(amount);
        }

        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankOperations bank = new BankOperations();

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string message = Console.ReadLine();
            Console.WriteLine(bank.ProcessOperation(message));
        }
    }
}