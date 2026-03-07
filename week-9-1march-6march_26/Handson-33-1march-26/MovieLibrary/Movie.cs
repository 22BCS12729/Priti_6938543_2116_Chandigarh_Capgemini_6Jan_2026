using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using static System.Net.WebRequestMethods;

namespace MovieLibrary
{
    internal class Movie
    {
    }
    public interface IFilm
    {
        string Title { get; set; }
        string Director { get; set; }
        int Year { get; set; }
    }

    public interface IFilmLibrary
    {
        void AddFilm(IFilm film);
        void RemoveFilm(string title);
        List<IFilm> GetFilms();
        List<IFilm> SearchFilms(string query);
        int GetTotalFilmCount();
    }


    public class Film : IFilm
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
    }

    public class FilmLibrary : IFilmLibrary
    {
        private List<IFilm> _films = new List<IFilm>();

        public void AddFilm(IFilm film)
        {
            _films.Add(film);
        }
        public  void RemoveFilm(string title)
        {
            var film = _films.FirstOrDefault(f => f.Title == title);
            if (film != null)
            {
                _films.Remove(film);
            }
        }

        public List<IFilm> GetFilms()
        {
            return _films;
        }

        public List<IFilm> SearchFilms(string query)
        {
            return _films
                .Where(f => f.Title.Contains(query) ||
                         f.Director.Contains(query))
                         .ToList();
        }

        public int GetFilmCount()
        {
            return _films.Count;
        }

    }

}