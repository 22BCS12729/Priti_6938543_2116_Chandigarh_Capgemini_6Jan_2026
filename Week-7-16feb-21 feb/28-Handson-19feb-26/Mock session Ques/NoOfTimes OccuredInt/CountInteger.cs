using System;
using System.Collections.Generic;
using System.Text;

namespace NoOfTimes_OccuredInt
{
    internal class CountInteger
    {
        public static void CountInt(int[] arr)
        {
            Dictionary<int,int>frq=new Dictionary<int,int>();

            foreach(int num in arr)
            {
                if (frq.ContainsKey(num))
                {
                    frq[num]++;
                }
                else
                {
                    frq[num] = 1;
                }
            }
            foreach(var item in frq)
            {
                Console.WriteLine(item.Key + "occurs"+ item.Value + "times");
            }
        }
    }
}
