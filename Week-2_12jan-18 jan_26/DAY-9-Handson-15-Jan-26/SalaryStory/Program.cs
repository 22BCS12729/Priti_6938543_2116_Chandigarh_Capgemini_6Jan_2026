namespace SalaryStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter Salary:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Working Days:");
            int days = int.Parse(Console.ReadLine());

            int result= SalCal.CalculateSavings(salary, days);

            Console.WriteLine("Saved Amount: " + result);

            Console.ReadLine();
        }
    }
}


