    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IBook
    {
        int Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Category { get; set; }
        int Price { get; set; }
    }

    public interface ILibrarySystem
    {
        void AddBook(IBook book, int quantity);
        int CalculateTotal();
        List<(string, int)> CategoryTotalPrice();
        List<(string, int, int)> BooksInfo();
        List<(string, string, int)> CategoryAndAuthorWithCount();
    }

    public class Book : IBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }

    public class LibrarySystem : ILibrarySystem
    {
        Dictionary<int, (IBook book, int quantity)> books =
            new Dictionary<int, (IBook, int)>();

        public void AddBook(IBook book, int quantity)
        {
            books.Add(book.Id, (book, quantity));
        }

        public int CalculateTotal()
        {
            return books.Values.Sum(x => x.book.Price * x.quantity);
        }

        public List<(string, int)> CategoryTotalPrice()
        {
            return books.Values
                .GroupBy(x => x.book.Category)
                .Select(g => (g.Key, g.Sum(x => x.book.Price * x.quantity)))
                .ToList();
        }

        public List<(string, int, int)> BooksInfo()
        {
            return books.Values
                .Select(x => (x.book.Title, x.quantity, x.book.Price))
                .ToList();
        }

        public List<(string, string, int)> CategoryAndAuthorWithCount()
        {
            return books.Values
                .GroupBy(x => new { x.book.Category, x.book.Author })
                .Select(g => (g.Key.Category, g.Key.Author, g.Sum(x => x.quantity)))
                .ToList();
        }
    }

    class Solution
    {
        static void Main()
        {
            ILibrarySystem library = new LibrarySystem();

            // Books from PDF example
            library.AddBook(new Book
            {
                Id = 1,
                Title = "PeterPan",
                Author = "JamesMathewBarrie",
                Category = "KidsClassics",
                Price = 193
            }, 11);

            library.AddBook(new Book
            {
                Id = 2,
                Title = "TheWizardOfOz",
                Author = "FrankBaum",
                Category = "KidsClassics",
                Price = 394
            }, 3);

            Console.WriteLine("Book Info:");

            foreach (var (title, quantity, price) in library.BooksInfo())
            {
                Console.WriteLine($"Book Name:{title}, Quantity:{quantity}, Price:{price}");
            }

            Console.WriteLine("Category Total Price:");

            foreach (var (category, totalPrice) in library.CategoryTotalPrice())
            {
                Console.WriteLine($"Category:{category}, Total Price:{totalPrice}");
            }

            Console.WriteLine("Category And Author With Count:");

            foreach (var (category, author, count) in library.CategoryAndAuthorWithCount())
            {
                Console.WriteLine($"Category:{category}, Author:{author}, Count:{count}");
            }

            Console.WriteLine($"Total Price: {library.CalculateTotal()}");
        }
    }