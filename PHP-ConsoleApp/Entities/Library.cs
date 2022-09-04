using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Models
{
    public class Library
    {
        public List<Book> books;
        public string Name { get; set; } = null!;
        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
        }

    }
}
