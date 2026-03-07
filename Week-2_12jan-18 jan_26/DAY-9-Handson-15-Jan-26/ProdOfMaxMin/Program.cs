namespace ProdOfMaxMin
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size");
            int n = int.Parse(Console.ReadLine());

            int[]arr=new int[n];

            Console.WriteLine("Enter Array Element");

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int res = ProdOfMaxMin.Product(n, arr);
            Console.WriteLine("Output=" + res);

        }
    }
}
