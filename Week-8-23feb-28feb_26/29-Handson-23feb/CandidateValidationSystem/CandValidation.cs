using System;

namespace CandidateValidationSystem
{
    public class Candidate
    {
        public string name { get; set; }
        public int totalRating { get; set; }
        public int totalContest { get; set; }
    }

    public class CriteriaMismatchException : Exception
    {
        public CriteriaMismatchException(string message) : base(message)
        {
        }
    }

    public class Validator
    {
        public string Eligible(Candidate c)
        {
            if (c.totalRating < 2000)
                throw new CriteriaMismatchException("Rating criteria not met.");

            if (c.totalContest < 5)
                throw new CriteriaMismatchException("Contest participation criteria not met.");

            return "Candidate is eligible.";
        }

        public string SendInvite(Candidate c)
        {
            return Eligible(c) + " Invitation sent.";
        }
    }
}

