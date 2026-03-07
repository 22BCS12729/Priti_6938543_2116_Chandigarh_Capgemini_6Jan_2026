namespace CalSalSaving
{
    internal class Program
    {
        static void Main()
        {


            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter Salary");
            int sal=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days");
            int days=int.Parse(Console.ReadLine());

            int res=SavingCal.Calculate(sal, days) ;
            Console.WriteLine("output="+res);
        }
    }
}
