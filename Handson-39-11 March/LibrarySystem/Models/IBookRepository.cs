namespace LibrarySystem.Models
{
    public interface IBookRepository
    {
        Book GetBookById(int id);
    }
}