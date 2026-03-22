using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class BooksController : Controller
{
    private static List<BookViewModel> books = new List<BookViewModel>()
    {
        new BookViewModel { Id=1, Title="C# Basics", Author="John", PublishedYear=2020, Genre="Programming", IsAvailable=true },
        new BookViewModel { Id=2, Title="ASP.NET Core", Author="Smith", PublishedYear=2022, Genre="Web", IsAvailable=false, BorrowerName="Rahul" }
    };

    public IActionResult Index()
    {
        ViewBag.Message = "📚 Welcome to Library";
        ViewData["TotalBooks"] = books.Count;

        return View(books);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(BookViewModel model)
    {
        if (ModelState.IsValid)
        {
            model.Id = books.Count + 1;
            model.IsAvailable = true;

            books.Add(model);
            return RedirectToAction("Index");
        }
        return View(model);
    }
}