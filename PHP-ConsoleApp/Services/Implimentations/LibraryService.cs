using PHP_ConsoleApp.Models;
using PHP_ConsoleApp.Repositories.Interfaces;
using PHP_ConsoleApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Services.Implimentations
{
    public class LibraryService : ILibraryService
    {
        public ILibraryRepository _libraryRepository;
        public LibraryService(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }
        public bool AddBook(Book book)
        {
            if (book == null)
            {
                return false;
            }
            _libraryRepository.Add(book);
            return true;
        }

        public List<Book> FindAllBooks(Predicate<Book> predicate)
        {
            List<Book> FindBooks = _libraryRepository.FindAll(predicate);
            if (FindBooks == null)
            {
                throw new Exception();
            }
            return FindBooks;
        }

        public Book GetBook(Predicate<Book> predicate)
        {
            Book book = _libraryRepository.Get(predicate);
            if (book == null)
            {
                throw new Exception();
            }
            return book;
        }

        public int RemoveAllBooks(Predicate<Book> predicate)
        {
            return _libraryRepository.RemoveAll(predicate);
        }

        public void ShowBooks()
        {
            foreach (var item in _libraryRepository.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
