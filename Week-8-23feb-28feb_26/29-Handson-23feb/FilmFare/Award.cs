using System;
using System.Collections.Generic;
using System.Text;

namespace FilmFare
{
    internal class Award
    {
        public class Rating
        {
            public int imdbRating { get; set; }
            public int nominee { get; set; }
        }

        public class MovieRatingException : Exception
        {
            public MovieRatingException(string message) : base(message)
            {
            }
        }

        public class Validator
        {
            public string CanBeConsideredForTheAward(Rating r)
            {
                if (r.imdbRating < 7)
                    throw new MovieRatingException("IMDB rating must be 7 or above.");

                if (r.nominee < 4)
                    throw new MovieRatingException("Nominee count must be at least 4.");

                return "Movie can be considered for the award.";
            }

            public string SendInvite(Rating r)
            {
                return CanBeConsideredForTheAward(r) + " Invitation sent.";
            }
        }
    }
}
