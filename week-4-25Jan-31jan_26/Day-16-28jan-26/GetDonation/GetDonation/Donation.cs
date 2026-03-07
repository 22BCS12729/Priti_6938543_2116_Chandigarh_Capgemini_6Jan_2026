using System;
using System.Collections.Generic;
using System.Text;

namespace GetDonation
{
    internal class Donation
    {
        public static int getDonation(string[] input1, int input2)
        {
            HashSet<string> set = new HashSet<string>();

            foreach (string str in input1)
            {
                if (!str.All(char.IsDigit))
                {
                    return -2;
                }

                if (!set.Add(str))
                {
                    return -1;
                }
            }

            int totalDonation = 0;

            foreach (string str in input1)
            {
                if (str.Length < 7)
                    continue;

                int location = int.Parse(str.Substring(3, 3));
                int donation = int.Parse(str.Substring(6));

                if (location == input2)
                {
                    totalDonation += donation;
                }
            }

            return totalDonation;
        }
    }
}

