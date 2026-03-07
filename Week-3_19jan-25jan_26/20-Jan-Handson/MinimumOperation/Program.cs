namespace MinimumOperation
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the value of n");
            int n=int.Parse(Console.ReadLine());
            int res= MinOperation.minOperation(n);
            Console.WriteLine(res);
          
        }
    }
}
