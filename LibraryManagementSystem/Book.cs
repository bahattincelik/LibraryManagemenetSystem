using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; private set; }

        public void BorrowBook()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"Book '{Title}' borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is already borrowed.");
            }
        }

        public void ReturnBook()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"Book '{Title}' returned succesfully");
            }

            else
            {
                Console.WriteLine($"Book '{Title}' was not borrowed");
            }
        }

        public abstract void DisplayBookType();
    }
}
