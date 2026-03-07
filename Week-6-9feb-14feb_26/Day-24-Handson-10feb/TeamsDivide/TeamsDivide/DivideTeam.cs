using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsDivide
{
    internal class DivideTeam
    {
       public  static void DivideTeams(int[] skills, int[] teamSizes)
        {
            int totalSize = 0;
            foreach (int size in teamSizes)
                totalSize += size;

            if (totalSize != skills.Length)
            {
                Console.WriteLine("Team sizes do not match number of employees.");
                return;
            }

            int index = 0;

            for (int i = 0; i < teamSizes.Length; i++)
            {
                Console.WriteLine($"Team {i + 1}:");

                for (int j = 0; j < teamSizes[i]; j++)
                {
                    Console.Write(skills[index] + " ");
                    index++;
                }

                Console.WriteLine();
            }
        }
    }
}

