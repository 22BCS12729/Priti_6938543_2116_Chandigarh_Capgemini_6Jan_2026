using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models;

namespace LibrarySystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Details(int id)
        {
            var book = _repository.GetBookById(id);

            return View(book);
        }
    }
}