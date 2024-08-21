using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class EBook:Book
    {
        public string DownloadLink { get; set; }

        public override void DisplayBookType()
        {
            Console.WriteLine($"This is an EBook. Title: {Title}, Download Link: {DownloadLink}");
        }

    }
}
