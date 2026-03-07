namespace FirstNonReapeatingCahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter string:");
                string s = Console.ReadLine();

                char result = RepeatingChar.RepChar(s);

                if (result != '\0')
                    Console.WriteLine("First Non Repeating char " + result);
                else
                    Console.WriteLine("No non-repeating character found");
            }
        }
    }

