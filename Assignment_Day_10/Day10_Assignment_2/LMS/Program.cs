using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            Book firstBook = new Book();
            firstBook.BookTitle = "Harry Potter";
            firstBook.BookAuthor = "J.K Rowling";
            firstBook.BookISBN = "101";
            Borrower firstBorrower = new Borrower();
            firstBorrower.BorrowerName = "Samar";
            firstBorrower.CardNumber = "CARD001";
            myLibrary.AddNewBook(firstBook);
            myLibrary.AddBorrower(firstBorrower);
            myLibrary.BorrowLibraryBook("101", "CARD001");
            Console.WriteLine("Books List");
            foreach (Book currentBook in myLibrary.DisplayBooks())
            {
                Console.WriteLine(currentBook.BookTitle + " - " + currentBook.BookAuthor);
            }
            Console.WriteLine();
            Console.WriteLine("Borrowers List");
            foreach (Borrower currentBorrower in myLibrary.DisplayBorrowers())
            {
                Console.WriteLine(currentBorrower.BorrowerName);
                foreach (Book borrowedBook in currentBorrower.BorrowedBookList)
                {
                    Console.WriteLine("Borrowed Book : " + borrowedBook.BookTitle);
                }
            }
            myLibrary.ReturnLibraryBook("101", "CARD001");
            Console.ReadLine();
        }
    }
}