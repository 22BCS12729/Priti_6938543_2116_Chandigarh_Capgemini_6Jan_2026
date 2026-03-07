namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();


            Console.WriteLine(ReverseStrings.ReverseWords(s));
        }
    }
}