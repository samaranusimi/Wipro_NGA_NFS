using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement;

namespace LibraryManagementTests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void AddBookTest()
        {
            Library library = new Library();
            Book book = new Book();
            book.BookTitle = ".NET Programming";
            book.BookAuthor = "Andrew";
            book.BookISBN = "101";
            library.AddNewBook(book);
            Assert.AreEqual(1, library.LibraryBooks.Count);
        }


        [TestMethod]
        public void BorrowBookTest()
        {
            Library library = new Library();
            Book book = new Book();
            book.BookTitle = "ASP.NET Core";
            book.BookAuthor = "Microsoft";
            book.BookISBN = "101";
            Borrower borrower = new Borrower();
            borrower.BorrowerName = "Samar";
            borrower.CardNumber = "CARD101";
            library.AddNewBook(book);
            library.AddBorrower(borrower);
            library.BorrowLibraryBook("101", "CARD101");
            Assert.IsTrue(book.BookBorrowStatus);
        }
    }
}