namespace CountVolwels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the words");
            string s = Console.ReadLine();

            int res= CountVowels.CountVowel(s);
            Console.WriteLine(res); 

        }
    }
}
