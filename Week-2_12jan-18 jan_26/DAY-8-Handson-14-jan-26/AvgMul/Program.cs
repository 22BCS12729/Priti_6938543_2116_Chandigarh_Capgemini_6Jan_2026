namespace AvgMul
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int res= AvgMulUpToN.AverageOfMultiplesOfFive(input);
            Console.WriteLine(res);
        }

    }
}
