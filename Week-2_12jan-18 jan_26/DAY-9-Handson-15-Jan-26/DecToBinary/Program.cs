namespace DecToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());

            int[] res = DecimalToBinary.DecToBinary(n);

            Console.WriteLine("The Binary Output");
            for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }


        }
    }
}
