using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueWords
{
    internal class UniueWords
    {
        public static void FindUnique(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                bool isUnique = true;
                string sorted1 = String.Concat(words[i].OrderBy(c => c));

                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j)
                    {
                        string sorted2 = String.Concat(words[j].OrderBy(c => c));
                        if (sorted1 == sorted2)
                        {
                            isUnique = false;
                            break;
                        }
                    }
                }

                if (isUnique)
                    Console.Write(words[i] + " ");
            }
        }
    }
}
