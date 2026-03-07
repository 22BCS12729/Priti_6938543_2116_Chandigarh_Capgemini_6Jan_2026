namespace StringCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string res= CompressStr.Compressstring(s);
            Console.WriteLine(res);
        }
    }
}
