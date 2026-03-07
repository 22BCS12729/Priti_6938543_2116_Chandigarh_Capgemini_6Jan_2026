namespace BankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(100);

            account.Deposit(50);
            Console.WriteLine("Balance after deposit: " + account.Balance);

            account.Withdraw(30);
            Console.WriteLine("Balance after withdraw: " + account.Balance);
        }
    }
}