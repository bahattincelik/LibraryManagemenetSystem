using System;
using static LibraryManagementSystem.User;

namespace LibraryManagementSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
           EBook book1 = new EBook {Id=1, Title="1984", Author="George Orwell", DownloadLink="http://downloadlink.com" };
            PrintedBook book2 = new PrintedBook { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Shelflocation = "A1" };

            LibraryStaff staff = new LibraryStaff { Id = 1, Name = "Herr Müller" }; 

            staff.AddBook(book1);
            staff.AddBook(book2);

            staff.ListAllBooks();

            User user = new User {Id=2, Name="Frau Müller" };

            user.BookBorrowed += OnBookBorrowed;


            LibraryUtilities.DisplayBookInfo(book1);
            LibraryUtilities.DisplayBookInfo(book2);

            Book foundBook = await LibraryUtilities.FindBookAsync(new List<Book> { book1, book2 }, 2);
            if (foundBook != null)
            {
                Console.WriteLine($"Found book : {foundBook.Title}");
            }


            user.ReturnBook(book1 );

            LibraryUtilities.DisplayBookInfo(book1);

            Console.ReadLine();
        }

       private static void OnBookBorrowed(object sender, BookEventArgs e)
        {
            Console.WriteLine($"Notification: {e.Book.Title} has been borrowed");
        }
    }
}
