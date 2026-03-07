using System;
using System.Collections.Generic;
using System.Text;

namespace FindeThePos
{
    internal class FindthPosOfN
    {
        public static void FindPositions(string line)
        {
            int posThe = line.IndexOf("the");
            int posOf = line.IndexOf("of");

            Console.WriteLine(posThe == -1 ? -1 : posThe);
            Console.WriteLine(posOf == -1 ? -1 : posOf);
        }
    }
}

