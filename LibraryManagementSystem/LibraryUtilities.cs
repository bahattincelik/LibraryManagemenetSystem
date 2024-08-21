using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class LibraryUtilities
    {
        public static void DisplayBookInfo(Book book)
        {
            Console.WriteLine($"Book ID: {book.Id}, Title: {book.Title}, Author : {book.Author}, Borrowed : {book.IsBorrowed}");
        }

        public static async Task<Book> FindBookAsync(List<Book> books, int bookId)
        {
            Console.WriteLine("Searching for the book...");
            await Task.Delay(2000);
            return FindBookById(books, bookId);
        }


        private static Book FindBookById(List<Book> books, int bookId)
        {
            return books.Find(book => book.Id == bookId) ?? throw new InvalidOperationException("Book not found");
        }
    }
}
