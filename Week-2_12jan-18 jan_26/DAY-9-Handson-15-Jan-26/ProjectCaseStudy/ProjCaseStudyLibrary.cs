    using System;
    using System.Collections.Generic;
    using System.Threading;

          namespace ProjectCaseStudy
                    {
                        //enum
                        enum BookStatus
                        {
                            Available,
                            Issued
                        }

                        // struct
                        struct LibraryAddress
                        {
                            public string City;
                            public string State;

                            public void ShowAddress()
                            {
                                Console.WriteLine($"Library Location: {City}, {State}");
                            }
                        }

                        internal class ProjCaseStudyLibrary
                        {
                          //Interfaces
                            interface IBorrowable
                            {
                                void Borrow(LibraryUser user);
                                void Return();
                            }

                            interface ISearchable
                            {
                                void Search(string keyword);
                            }

                            //  ABSTRACT CLASSE
                            abstract class LibraryEntity
                            {
                                public string Name { get; set; }
                                public abstract void ShowDetails();
                            }

                            abstract class LibraryItem : LibraryEntity
                            {
                                public int ItemId { get; set; }

                                public BookStatus Status { get; protected set; } = BookStatus.Available;

                                public bool IsIssued => Status == BookStatus.Issued;

                                public abstract void Issue();
                            }

                            abstract class ReadingItem : LibraryItem
                            {
                                public abstract void Read();
                            }

                            abstract class PrintedItem : ReadingItem
                            {
                                public int Pages { 
                                  get;
                                  set; 
                                  }
                                public abstract void Open();
                            }

                            abstract class BookBase : PrintedItem
                            {
                                public string Author { get; set; }
                                public abstract void Close();
                            }

                          //Creating the book class
                            class Book : BookBase, IBorrowable, ISearchable
                            {
                                public override void ShowDetails()
                                {
                                    Console.WriteLine("\nBook Details");
                                    Console.WriteLine($"ID: {ItemId}");
                                    Console.WriteLine($"Name: {Name}");
                                    Console.WriteLine($"Author: {Author}");
                                    Console.WriteLine($"Pages: {Pages}");
                                    Console.WriteLine($"Status: {Status}");
                                }

                                public override void Issue()
                                {
                                    if (Status == BookStatus.Available)
                                    {
                                        Status = BookStatus.Issued;
                                        Console.WriteLine("Book issued successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book already issued");
                                    }
                                }

                                public override void Read()
                                {
                                    Console.WriteLine("Reading the book.");
                                }

                                public override void Open()
                                {
                                    Console.WriteLine("Book opened");
                                }

                                public override void Close()
                                {
                                    Console.WriteLine("Book closed");
                                }

                                public void Borrow(LibraryUser user)
                                {
                                    Issue();
                                    user.BorrowedItems.Add(this);
                                    Console.WriteLine($"{user.UserName} borrowed the book");
                                }

                                public void Return()
                                {
                                    Status = BookStatus.Available;
                                    Console.WriteLine("Book returned to library");
                                }

                                public void Search(string keyword)
                                {
                                    Console.WriteLine($"Searching book with keyword: {keyword}");
                                }
                            }

                            //userclass
                           class LibraryUser{
                               
                            public string UserName { 
                                       
                               get; 
                                       
                               set; 
                               }
                                public List<LibraryItem> BorrowedItems { 
                                get;
                                set; 
                                } = new List<LibraryItem>();

                                public void ShowBorrowedItems()
                                {
                                    Console.WriteLine("\nBorrowed Items:");
                                    foreach (var item in BorrowedItems)
                                    {
                                        Console.WriteLine("- " + item.Name);
                                    }
                                }
                            }
                            class Repository<T>
                            {
                                private List<T> items = new List<T>();

                                public void Add(T item)
                                {
                                    items.Add(item);
                                }
                            }
                    //multithreading
                            internal class Program
                            {
                                static void BorrowBook(Book book, LibraryUser user)
                                {
                                    book.Borrow(user);
                                }

                                static void ReadBook(Book book)
                                {
                                    book.Read();
                                }

                                static void Main()
                                {
                                    // STRUCT USAGE
                                    LibraryAddress address;
                                    address.City = "Chandigarh";
                                    address.State = "Punjab";
                                    address.ShowAddress();

                                    // USER INPUT
                                    Console.Write("\nEnter User Name: ");
                                    string userName = Console.ReadLine();

                                    LibraryUser user = new LibraryUser { UserName = userName };

                                    Console.Write("Enter Book ID: ");
                                    int bookId = int.Parse(Console.ReadLine());

                                    Console.Write("Enter Book Name: ");
                                    string bookName = Console.ReadLine();

                                    Console.Write("Enter Author Name: ");
                                    string author = Console.ReadLine();

                                    Console.Write("Enter Number of Pages: ");
                                    int pages = int.Parse(Console.ReadLine());

                                    Book book = new Book
                                    {
                                        ItemId = bookId,
                                        Name = bookName,
                                        Author = author,
                                        Pages = pages
                                    };
                                    Repository<Book> repo = new Repository<Book>();
                                    repo.Add(book);

                                    book.ShowDetails();
                                    book.Open();

                                    Console.Write("\nEnter keyword to search: ");
                                    string keyword = Console.ReadLine();
                                    book.Search(keyword);

                                    Console.Write("Do you want to borrow (yes/no): ");
                                    string choice = Console.ReadLine();

                                    if (choice.ToLower() == "yes")
                                    {
                                        Thread t1 = new Thread(() => BorrowBook(book, user));
                                        Thread t2 = new Thread(() => ReadBook(book));

                                        t1.Start();
                                        t2.Start();

                                        t1.Join();
                                        t2.Join();
                                    }

                                    book.Close();
                                    Console.Write("Do you want to return the book (yes/no): ");
                                    string returnChoice = Console.ReadLine();

                                    if (returnChoice.ToLower() == "yes")
                                    {
                                        book.Return();
                                    }
                                    user.ShowBorrowedItems();
                                }
                            }
                        }
                    }
