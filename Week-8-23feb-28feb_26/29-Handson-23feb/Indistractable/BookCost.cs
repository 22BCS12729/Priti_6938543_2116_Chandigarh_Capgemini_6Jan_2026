using System;
using System.Collections.Generic;
using System.Text;

namespace Indistractable
{
    internal class BookCost
    {
        public class Book
        {
            public string bookName;
            public int bookCost;

            public Book(string bookName, int bookCost)
            {
                this.bookName = bookName;
                this.bookCost = bookCost;
            }
        }

        public class BookImplementation
        {
            public string GetNameOfBooks(List<Book> books)
            {
                string result = "";
                foreach (var book in books)
                {
                    result += book.bookName + " - " + book.bookCost + "\n";
                }
                return result;
            }

            public int SumCostOfAllBooks(List<Book> books)
            {
                return books.Sum(b => b.bookCost);
            }

            public int GetMax(List<Book> books)
            {
                return books.Max(b => b.bookCost);
            }
        }

    }
}
