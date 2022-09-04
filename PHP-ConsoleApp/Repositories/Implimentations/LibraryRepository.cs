using PHP_ConsoleApp.DAL;
using PHP_ConsoleApp.Models;
using PHP_ConsoleApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Repositories.Implimentations
{
    public class LibraryRepository : ILibraryRepository 
    {
        private readonly Context _context;
        public LibraryRepository(Context context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            _context._library.books.Add(book);
        }

        public List<Book> FindAll(Predicate<Book> method)
        {
            return _context._library.books.FindAll(method);
        }

        public Book Get(Predicate<Book> method)
        {
          return _context._library.books.Find(method);
        }

        public List<Book> GetAll()
        {
            return _context._library.books;
        }

        public int RemoveAll(Predicate<Book> method)
        {
           return _context._library.books.RemoveAll(method);
        }
    }
}
