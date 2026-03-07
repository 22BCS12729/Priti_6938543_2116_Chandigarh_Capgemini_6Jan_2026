namespace GrossSalaryCal
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the Basic Salary");
            int BP = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the No. Of Working Days");
            int WD = int.Parse(Console.ReadLine());

        
            int res = GrossSalary.CalGross(BP, WD);
            Console.WriteLine(res);
        }
    }
}
