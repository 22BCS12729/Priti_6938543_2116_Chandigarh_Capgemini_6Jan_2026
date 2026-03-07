using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Implement
{
    internal class PolymorphismLibraryProj
    {
            static void Main(string[] args)
            {
                LibraryMember m1 = new StudentMember();
                LibraryMember m2 = new StaffMember();
                LibraryPolicy policy = new LibraryPolicy();
                Console.WriteLine("Student Borrow Limit: " + policy.CheckBorrowLimit(m1));
                Console.WriteLine("Staff Borrow Limit: " + policy.CheckBorrowLimit(m2));
                IFineCalculator fine1 = new StudentFine();
                IFineCalculator fine2 = new StaffFine();
                Console.WriteLine("Student Fine: " + fine1.CalculateFine(5));
                Console.WriteLine("Staff Fine: " + fine2.CalculateFine(5));
                LibraryAccount acc1 = new DigitalAccount();
                LibraryAccount acc2 = new PhysicalAccount();
                Console.WriteLine(acc1.AccountType());
                Console.WriteLine(acc2.AccountType());
                BookService service = new BookService();
                Console.WriteLine(service.IssueBook("C# Book"));
                Console.WriteLine(service.IssueBook("Java Book", 7));
                Console.WriteLine(service.IssueBook("Python Book", 10, "Student"));
            }
        }

        public class LibraryMember
        {
            public virtual int GetBorrowLimit()
            {
                return 2;
            }
        }
        public class StudentMember:LibraryMember
        {
            public override int GetBorrowLimit()
            {
                return 3;
            }
        }
        public class StaffMember:LibraryMember
        {
            public override int GetBorrowLimit()
            {
                return 5;
            }
        }    
    public interface IFineCalculator
        {
            int CalculateFine(int daysLate);
        }

    public class StudentFine : IFineCalculator
    {
        public int CalculateFine(int daysLate)
        {
            return daysLate * 2;
        }
    }
        public class StaffFine : IFineCalculator
        {
            public int CalculateFine(int lateDays)
            {
                return lateDays* 1;
            }
        }
        public abstract class LibraryAccount
        {
            public abstract string AccountType();
        }

        public class DigitalAccount : LibraryAccount
        {
            public override string AccountType()
            {
                return "Digital Library Account";
            }
        }

        public class PhysicalAccount : LibraryAccount
        {
            public override string AccountType()
            {
                return "Physical Library Account";
            }
        }
          public class BookService
        {
            public string IssueBook(string bookName)
            {
                return bookName + " issued";
            }
            public string IssueBook(string bookName, int days)
            {
                return bookName + " issued for " + days + " days";
            }

            public string IssueBook(string bookName, int days, string memberType)
            {
                return bookName + " issued to " + memberType + " for " + days + " days";
            }
        }

        public class LibraryPolicy
        {
            public int CheckBorrowLimit(LibraryMember member)
            {
                return member.GetBorrowLimit();
            }
        }

    }


