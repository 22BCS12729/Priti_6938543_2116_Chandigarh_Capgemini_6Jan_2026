using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCU
{
    internal class LibraryClassCaseStdy
    {
        int BookId;
        readonly string LibraryName;
        static int TotalBooks;
        const string Country = "India";

        static LibraryClassCaseStdy()
        {
            TotalBooks = 100;

        }
        LibraryClassCaseStdy()
        {
            BookId = 0;
            LibraryName = "Central Library";
        }
        LibraryClassCaseStdy(int bookId, string libraryName)
        {
            BookId = bookId;
            LibraryName = libraryName;
        }
        void Display()
        {
            Console.WriteLine("The BookId is-" + BookId);
            Console.WriteLine("The Library Name is-" + LibraryName);
            Console.WriteLine("The total No of Books-" + TotalBooks);
            Console.WriteLine("The Country Name is-" + Country);

        }
        static void Main()
        {
            LibraryClassCaseStdy c = new LibraryClassCaseStdy();
            c.Display();

            LibraryClassCaseStdy c1 = new LibraryClassCaseStdy(102, "City Library");
            c1.Display();
        }
    }


}
