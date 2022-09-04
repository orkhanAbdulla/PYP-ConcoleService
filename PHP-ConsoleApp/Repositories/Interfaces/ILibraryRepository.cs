using PHP_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Repositories.Interfaces
{
    public interface ILibraryRepository
    {
        public void Add(Book book);
        public List<Book> GetAll();
        public Book Get(Predicate<Book> method);
        public List<Book> FindAll(Predicate<Book> method);
        public int RemoveAll(Predicate<Book> method);
        
    }
}
