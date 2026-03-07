using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class BankAccount
    {
        protected int accountNumber;
        protected string holderName;
        protected double balance;

        public BankAccount(int accNo, string name, double bal)   // ❗ constructor name corrected
        {
            accountNumber = accNo;
            holderName = name;
            balance = bal;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited: " + amount);
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Amount Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public virtual void Display()
        {
            Console.WriteLine("Account No: " + accountNumber);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class SavingsAccount : BankAccount
    {
        double interestRate = 0.04;

        public SavingsAccount(int accNo, string name, double bal)
            : base(accNo, name, bal) { }

        public void AddInterest()
        {
            double interest = balance * interestRate;
            balance += interest;
            Console.WriteLine("Interest Added: " + interest);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Account Type: Savings");
        }
    }

    class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accNo, string name, double bal)
            : base(accNo, name, bal) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Account Type: Checking");
        }
    }
}
