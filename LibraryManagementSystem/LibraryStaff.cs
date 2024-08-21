using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryStaff:User, ILibraryActions
    {
        private List<Book> LibraryBooks {  get; set; }= new List<Book>();

        public void AddBook(Book book)
        { 
            if(book!=null)
            {

            LibraryBooks.Add(book);
                Console.WriteLine($"Book '{book.Title}' added to the library");
            }
        
        }

        public void RemoveBook(Book book)
        {
            if (LibraryBooks.Contains(book))
            {
                LibraryBooks.Remove(book);
                Console.WriteLine($"Book '{book.Title}' removed from the library");

            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' not found in the library");
            }
        }

        public void ListAllBooks()
        {
            Console.WriteLine("Listing all books in the library");
            foreach (var book in LibraryBooks)
            {
                LibraryUtilities.DisplayBookInfo(book);
            }
        }
    }
}
