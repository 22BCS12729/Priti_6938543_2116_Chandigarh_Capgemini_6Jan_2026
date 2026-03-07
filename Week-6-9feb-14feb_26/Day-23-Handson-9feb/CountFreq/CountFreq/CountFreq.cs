using System;
using System.Collections.Generic;
using System.Text;

namespace CountFreq
{
    internal class CountFreq
    {
        public static void CountFrequency(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (var item in freq)
                Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}

