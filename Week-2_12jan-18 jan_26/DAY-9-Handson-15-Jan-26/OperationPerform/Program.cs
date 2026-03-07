namespace OperationPerform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter z:");
            int z = int.Parse(Console.ReadLine());

            int result = OperationPerform1. Calculate(x, y, z);
            Console.WriteLine(result);
        }
    }
}
