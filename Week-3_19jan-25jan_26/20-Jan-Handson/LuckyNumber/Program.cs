namespace LuckyNumber
{
    internal class Program
    {
        static void Main()
        {
            {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                int result = LuckyNumber.luckynumbers(m, n);

                Console.WriteLine(result);
            }
        }
    }
}
    