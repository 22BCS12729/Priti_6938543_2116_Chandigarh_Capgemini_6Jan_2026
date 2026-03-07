namespace ValidParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string s = Console.ReadLine();

            bool res = ParenthesisCheck.IsValid(s);
            if (res)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
