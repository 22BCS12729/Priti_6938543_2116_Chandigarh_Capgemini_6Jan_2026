using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace InventoryManangement
{


    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
    internal class Inventory_Management
    {
        
        //Creating book Inventory
            public static List<Book> CreateInventory()
            {
                return new List<Book>
            {
                new Book { Id = 1, Title = "C# Basics", Price = 450, Stock = 10 },
                new Book { Id = 2, Title = "LINQ Mastery", Price = 600, Stock = 5 },
                new Book { Id = 3, Title = "ASP.NET", Price = 800, Stock = 0 },
                new Book { Id = 4, Title = "SQL Guide", Price = 300, Stock = 8 }
            };
            }
        //Adding books
            public static void AddBook(List<Book> books, Book book)
            {
                books.Add(book);
                Console.WriteLine("Book added successfully.");
            }

            public static void FindBooksCheaperThan(List<Book> books, double price)
            {
                var result = books.Where(b => b.Price < price);

                Console.WriteLine("\nBooks cheaper than " + price);
                foreach (var b in result)
                {
                    Console.WriteLine(b.Title + " - " + b.Price);
                }
            }

            public static void IncreasePrice(List<Book> books, double percentage)
            {
                books.ForEach(b =>
                {
                    b.Price += b.Price * percentage / 100;
                });

                Console.WriteLine("\nPrices increased by " + percentage + "%");
            }

            public static List<Book> RemoveOutOfStock(List<Book> books)
            {
                Console.WriteLine("\nOut-of-stock books removed.");
                return books.Where(b => b.Stock > 0).ToList();
            }

            public static void DisplayInventory(List<Book> books)
            {
                Console.WriteLine("\nFinal Inventory:");
                foreach (var b in books)
                {
                    Console.WriteLine($"{b.Id} {b.Title} {b.Price} {b.Stock}");
                }
            }
        }
    }


