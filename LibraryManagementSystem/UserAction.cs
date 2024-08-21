using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public partial class User
    {
        public void ListBorrowedBooks()
        {
            Console.WriteLine($"{Name} has borrowed the folwing books");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
}
