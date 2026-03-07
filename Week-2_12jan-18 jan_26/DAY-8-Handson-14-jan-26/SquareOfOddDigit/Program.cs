namespace SquareOfOddDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           int input=int.Parse(Console.ReadLine());
            int res = SquarOddDigit.SumOfSquaresOfOddDigits(input);
            Console.WriteLine(res);
        }
    }
}
