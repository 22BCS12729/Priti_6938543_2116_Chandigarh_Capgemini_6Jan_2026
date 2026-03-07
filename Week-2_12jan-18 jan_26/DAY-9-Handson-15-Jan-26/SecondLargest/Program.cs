namespace SecondLargest
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the size of the Element");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Array Elements");
            for(int i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int output = SecLarElement.secondLarEle(n, arr);

            Console.WriteLine("Output is"+output);

        }
    }
}
