namespace StringManipulationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringPlay sp = new StringPlay();
            StringMethods sm = new StringMethods();

            int result = sm.ConvertToInt(sp, "1234");
            Console.WriteLine("Converted Integer: " + result);

            int count = sm.GetMax(sp, "banana", 'a');
            Console.WriteLine("Character Count: " + count);

            Console.ReadLine();
        }
    }
}