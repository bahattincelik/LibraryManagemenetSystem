using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class PrintedBook:Book
    {
        public string Shelflocation {  get; set; }

        public override void DisplayBookType()
        {
            Console.WriteLine($"This is a Printed Book. Title : {Title}, Shelf Location: {Shelflocation}");
        }
    }
}
