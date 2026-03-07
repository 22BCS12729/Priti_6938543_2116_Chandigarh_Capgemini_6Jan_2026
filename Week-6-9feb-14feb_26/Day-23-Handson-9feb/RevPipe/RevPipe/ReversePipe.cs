using System;
using System.Collections.Generic;
using System.Text;

namespace RevPipe
{
    internal class ReversePipe
    {
        public static void ReversePipe(string str)
        {
            string[] words = str.Split('|');
            Array.Reverse(words);
            Console.WriteLine(string.Join("|", words));
        }
    }
}

