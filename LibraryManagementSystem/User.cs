using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public delegate void BookBorrowedHandler(object sender, BookEventArgs e);
        public event BookBorrowedHandler? BookBorrowed;

        public void BorrowBook (Book book)
        { 
            if (!book.IsBorrowed)
            {
                book.BorrowBook();
                BorrowedBooks.Add(book);
                OnBookBorrowed(book);
            }
                
        }

        protected virtual void OnBookBorrowed(Book book)
        {
            if (BookBorrowed != null)
            {
                BookBorrowed(this, new BookEventArgs { Book = book });
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.ReturnBook();
                BorrowedBooks.Remove(book);
            }
            else { Console.WriteLine($"User '{Name}' does not have this book"); }
        }

        public class BookEventArgs : EventArgs
        {
            public Book? Book { get; set; }
        }
    }
}
