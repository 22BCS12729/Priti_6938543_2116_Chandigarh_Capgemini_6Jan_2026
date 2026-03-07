using System;
using System.Collections.Generic;
using System.Text;

namespace CheckVotingElg
{
    internal class CheckVotingEligibility
    {
        public static bool IsEligible(int age)
        {
            return  age >= 18;
        }
    }
}
