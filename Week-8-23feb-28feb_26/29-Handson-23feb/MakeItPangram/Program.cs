using PangramValidation;

namespace MakeItPangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pangram p = new Pangram();

            string sentence = "The quick brown fox jumps over the lazy dog";

            int missing = p.MinimumAlphabet(sentence);

            Console.WriteLine("Missing Alphabets Count: " + missing);

            Console.ReadLine();
        }
    }
}