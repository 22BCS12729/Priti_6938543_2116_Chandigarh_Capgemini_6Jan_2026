namespace LuckyString
{
    internal class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello, World!");


            int n = int.Parse(Console.ReadLine());
            string s=Console.ReadLine();
            Console.WriteLine(LuckyStrings.IsLuckyStrings(n, s));
        }
    }
}
