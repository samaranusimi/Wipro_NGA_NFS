using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> LibraryBooks = new List<Book>();
        public List<Borrower> LibraryBorrowers = new List<Borrower>();
        public void AddNewBook(Book newBook)
        {
            LibraryBooks.Add(newBook);
        }
        public void AddBorrower(Borrower newBorrower)
        {
            LibraryBorrowers.Add(newBorrower);
        }
        public void BorrowLibraryBook(string isbnNumber, string borrowerCardNumber)
        {
            var selectedBook = LibraryBooks.FirstOrDefault(b => b.BookISBN == isbnNumber);
            var selectedBorrower = LibraryBorrowers.FirstOrDefault(b => b.CardNumber == borrowerCardNumber);
            if (selectedBook != null && selectedBorrower != null && !selectedBook.BookBorrowStatus)
            {
                selectedBook.BorrowBook();

                selectedBorrower.AddBorrowedBook(selectedBook);
            }
        }
        public void ReturnLibraryBook(string isbnNumber, string borrowerCardNumber)
        {
            var selectedBook = LibraryBooks.FirstOrDefault(b => b.BookISBN == isbnNumber);
            var selectedBorrower = LibraryBorrowers.FirstOrDefault(b => b.CardNumber == borrowerCardNumber);
            if (selectedBook != null && selectedBorrower != null && selectedBook.BookBorrowStatus)
            {
                selectedBook.ReturnBook();
                selectedBorrower.RemoveBorrowedBook(selectedBook);
            }
        }
        public List<Book> DisplayBooks()
        {
            return LibraryBooks;
        }
        public List<Borrower> DisplayBorrowers()
        {
            return LibraryBorrowers;
        }
    }
}