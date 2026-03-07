namespace StringCompress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string compressed = StringCompression.Compress(s);
            Console.WriteLine(compressed);
        }
    }
}
