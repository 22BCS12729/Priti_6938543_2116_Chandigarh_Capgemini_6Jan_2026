namespace InventoryManangement
{
    internal class Program
    {
 
            static void Main(string[] args)
            {
                List<Book> books = Inventory_Management.CreateInventory();

            Inventory_Management.AddBook(books, new Book
                {
                    Id = 5,
                    Title = "Azure Fundamentals",
                    Price = 550,
                    Stock = 6
                });

            Inventory_Management.FindBooksCheaperThan(books, 500);

            Inventory_Management.IncreasePrice(books, 10);

                books = Inventory_Management.RemoveOutOfStock(books);

            Inventory_Management.DisplayInventory(books);

                Console.ReadLine();
            }
        }
    }
