using static Indistractable.BookCost;

namespace Indistractable
{
    internal class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>()
        {
            new Book("Atomic Habits", 500),
            new Book("Indistractable", 650),
            new Book("Deep Work", 400)
        };

            BookImplementation obj = new BookImplementation();

            Console.WriteLine("Book Name and Cost:");
            Console.WriteLine(obj.GetNameOfBooks(books));

            Console.WriteLine("Total Cost: " + obj.SumCostOfAllBooks(books));
            Console.WriteLine("Maximum Book Cost: " + obj.GetMax(books));
        }
    }
}
