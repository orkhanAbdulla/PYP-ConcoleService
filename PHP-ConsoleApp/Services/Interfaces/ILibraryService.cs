using PHP_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Services.Interfaces
{
    public interface ILibraryService
    {
        public void ShowBooks();
        public bool AddBook(Book book);
        public Book GetBook(Predicate<Book> predicate);
        public List<Book> FindAllBooks(Predicate<Book> predicate);
        public int RemoveAllBooks(Predicate<Book> predicate);
    }
}
