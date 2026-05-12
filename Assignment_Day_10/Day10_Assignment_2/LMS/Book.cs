namespace LibraryManagement
{
    public class Book
    {
        public string BookTitle { get; set; }

        public string BookAuthor { get; set; }

        public string BookISBN { get; set; }

        public bool BookBorrowStatus { get; set; }


        public void BorrowBook()
        {
            BookBorrowStatus = true;
        }


        public void ReturnBook()
        {
            BookBorrowStatus = false;
        }
    }
}