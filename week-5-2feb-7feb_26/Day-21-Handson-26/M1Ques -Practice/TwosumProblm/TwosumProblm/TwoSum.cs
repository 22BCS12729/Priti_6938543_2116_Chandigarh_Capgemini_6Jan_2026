using System;
using System.Collections.Generic;
using System.Text;

namespace TwosumProblm
{
    internal class TwoSum
    {
        public static int[]TwoSumprob(int[]nums,int target)
        {
            Dictionary<int,int>map=new Dictionary<int,int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                if (map.ContainsKey(rem))
                {
                    return new int[]
                    {
                        map[rem],i
                    };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i],i);
                }
            }
            return new int[0];
        }
    }
}
