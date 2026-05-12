using System.Collections.Generic;

namespace LibraryManagement
{
    public class Borrower
    {
        public string BorrowerName { get; set; }

        public string CardNumber { get; set; }


        public List<Book> BorrowedBookList  = new List<Book>();


        public void AddBorrowedBook(Book selectedBook)
        {
            BorrowedBookList.Add(selectedBook);
        }


        public void RemoveBorrowedBook(Book selectedBook)
        {
            BorrowedBookList.Remove(selectedBook);
        }
    }
}