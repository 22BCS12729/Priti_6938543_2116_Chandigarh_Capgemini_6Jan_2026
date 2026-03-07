namespace CandidateValidationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candidate candidate = new Candidate
            {
                name = "Krishna",
                totalRating = 2100,
                totalContest = 6
            };

            Validator validator = new Validator();

            try
            {
                Console.WriteLine(validator.SendInvite(candidate));
            }
            catch (CriteriaMismatchException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}