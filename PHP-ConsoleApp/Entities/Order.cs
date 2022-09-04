using PHP_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Entities
{
    public class Order
    {
        private int Id { get; set; }
        private static int _id;
        public decimal TotalPrice { get; set; }
        public DateTime Data { get; set; }
        public List<Book> books;
        public Order()
        {
            Id = ++_id;
            books = new List<Book>();  
        }
        public void ShowSale()
        {
            Console.WriteLine($"Id:{Id} Data:{Data} TotalPrice:{TotalPrice}");
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }

    }
}
