namespace LongestSubString
{
    internal class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello, World!");
            string s = Console.ReadLine();
            int res = LongestSubStringLength.Longsub(s);
            Console.WriteLine(res); 

        }
    }
}
