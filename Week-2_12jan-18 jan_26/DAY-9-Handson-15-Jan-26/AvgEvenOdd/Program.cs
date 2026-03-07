namespace AvgEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the size");
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int res = EvenOddAvg.Average(arr, n);
            Console.WriteLine("The Average= " + res);

        }
    }
}
