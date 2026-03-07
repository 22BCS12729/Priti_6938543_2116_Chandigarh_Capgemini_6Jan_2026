namespace MulSum
{
    internal class Program
    {
        static void Main()
        {
            //  Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the inp1");
            int inp1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the inp2");
            int inp2=int.Parse(Console.ReadLine());

            int res = FactorSum.FacSum(inp1, inp2);
            Console.WriteLine(res);
        }
    }
}
