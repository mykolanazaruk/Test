using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3.DataModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext contaxt = new LibraryContext())
            {
                Book book = new Book();
                book.Title = "Anna Karrenina";
                book.Author = "Lew Tolstoi";

                contaxt.Books.Add(book);
                contaxt.SaveChanges();
            }
        }
    }
}

