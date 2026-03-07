namespace ShipStory
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the value of n1,n2");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n1];
            int[] arr2 = new int[n2];
            Console.WriteLine("Enter the Array 1 and Array2 Elements");
            for (int i = 0; i < n1; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
                arr2[i] = int.Parse(Console.ReadLine());

            int[] output = ArraySum.AddFrontWithBack(arr1, arr2, n1, n2);

            foreach (int val in output)
                Console.Write("Value= " +"  "+val);
            Console.ReadLine();
        }
    }
}



