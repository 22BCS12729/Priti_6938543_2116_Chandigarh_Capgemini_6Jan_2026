namespace AddElementArrays
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of Array:-");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(-2);
                return;
            }

            int[] inp1 = new int[n];
            int[] inp2 = new int[n];

            Console.WriteLine("Enter the first Array Element");

            for(int i = 0; i <n; i++)
            {
                inp1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the Sec Array Elements");

            for(int i = 0; i < n; i++)
            {
                inp2[i] = int.Parse(Console.ReadLine());
            }

            int[] res = AddArrayElem.AddArray(inp1, inp2, n);


            Console.WriteLine("Output");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(res[i] + " ");
            }


        }
    }
}
