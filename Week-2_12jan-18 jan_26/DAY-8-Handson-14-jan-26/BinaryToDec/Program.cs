namespace BinaryToDec
{
    internal class Program
    {
        static void Main()
        {
            string inp = Console.ReadLine();
            int res = BinToDec.BinaryToDecimal(inp);
            Console.WriteLine(res);
        }

    }
}
