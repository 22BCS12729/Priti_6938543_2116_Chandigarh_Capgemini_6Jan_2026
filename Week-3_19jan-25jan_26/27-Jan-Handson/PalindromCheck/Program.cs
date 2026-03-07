namespace PalindromCheck
{
    internal class Program
    {
            static void Main()
            {
                Console.WriteLine("Enter the Words");
                string s = Console.ReadLine();

                bool res = Palindrome.IsPalindrom(s);
                Console.WriteLine(res);
            }
        }
    }
