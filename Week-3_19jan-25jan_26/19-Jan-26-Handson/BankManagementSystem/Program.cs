namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
                SavingsAccount sa = new SavingsAccount(101, "Priti", 5000);
                sa.Deposit(2000);
                sa.AddInterest();
                sa.Withdraw(1000);
                sa.Display();

                Console.WriteLine();

                CheckingAccount ca = new CheckingAccount(201, "Rahul", 3000);
                ca.Deposit(1000);
                ca.Withdraw(500);
                ca.Display();
            }
        }
    }
