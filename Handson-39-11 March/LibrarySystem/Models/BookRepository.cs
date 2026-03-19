namespace LibrarySystem.Models
{
    public class BookRepository : IBookRepository
    {
        public Book GetBookById(int id)
        {
            return new Book
            {
                Id = id,
                Title = "ASP.NET Core Programming",
                Author = "Priti Mehta"
            };
        }
    }
}