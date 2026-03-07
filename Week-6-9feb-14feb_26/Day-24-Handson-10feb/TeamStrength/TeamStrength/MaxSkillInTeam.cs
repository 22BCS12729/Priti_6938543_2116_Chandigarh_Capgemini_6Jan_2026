using System;
using System.Collections.Generic;
using System.Text;

namespace TeamStrength
{
    internal class MaxSkillInTeam
    {
       public  static int MaxTotalStrength(int[] skills, int[] teamSizes)
        {
            Array.Sort(skills);
            Array.Sort(teamSizes);

            int left = 0;
            int right = skills.Length - 1;
            int totalStrength = 0;

            foreach (int size in teamSizes)
            {
                int maxSkill = skills[right--];
                int minSkill = skills[left];

                totalStrength += maxSkill + minSkill;

                left += size - 1;
            }

            return totalStrength;
        }
    }
}

