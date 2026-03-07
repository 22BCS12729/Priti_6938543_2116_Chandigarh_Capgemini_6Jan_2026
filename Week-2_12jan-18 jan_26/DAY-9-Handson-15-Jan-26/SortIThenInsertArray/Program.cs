namespace SortIThenInsertArray
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter size of array:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element to insert:");
            int x = int.Parse(Console.ReadLine());

            int[] result = SortInsertArray.InsertElement(n, arr, x);

            foreach (int i in result)
            {
                Console.Write(i + " ");

            }

        }
    }
}
