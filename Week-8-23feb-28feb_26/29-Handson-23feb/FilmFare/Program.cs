using static FilmFare.Award;

namespace FilmFare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rating rating = new Rating
            {
                imdbRating = 8,
                nominee = 5
            };

            Validator validator = new Validator();

            try
            {
                Console.WriteLine(validator.SendInvite(rating));
            }
            catch (MovieRatingException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}