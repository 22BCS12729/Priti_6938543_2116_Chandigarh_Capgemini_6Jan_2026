namespace MovieLibrary
{
    
        public class Program
        {
            public static void Main()
            {
                FilmLibrary library = new FilmLibrary();

                // Adding films
                library.AddFilm(new Film { Title = "Inception", Director = "Christopher Nolan", Year = 2010 });
                library.AddFilm(new Film { Title = "Interstellar", Director = "Christopher Nolan", Year = 2014 });
                library.AddFilm(new Film { Title = "Avatar", Director = "James Cameron", Year = 2009 });

                Console.WriteLine("All Films:");
                foreach (var film in library.GetFilms())
                {
                    Console.WriteLine($"{film.Title} - {film.Director} - {film.Year}");
                }

                Console.WriteLine("\nSearch Result for 'Nolan':");
                var searchResults = library.SearchFilms("Nolan");
                foreach (var film in searchResults)
                {
                    Console.WriteLine($"{film.Title} - {film.Director} - {film.Year}");
                }

                Console.WriteLine("\nTotal Films: " + library.GetTotalFilmCount());

                // Remove a film
                library.RemoveFilm("Avatar");

                Console.WriteLine("\nAfter Removing 'Avatar':");
                foreach (var film in library.GetFilms())
                {
                    Console.WriteLine($"{film.Title} - {film.Director} - {film.Year}");
                }

                Console.WriteLine("\nTotal Films Now: " + library.GetTotalFilmCount());
            }
        }