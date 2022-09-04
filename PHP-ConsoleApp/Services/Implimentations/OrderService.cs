using PHP_ConsoleApp.Entities;
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
    public class OrderService:IOrderService
    {
        public ILibraryRepository _libraryRepository;

        public OrderService(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }
        public Order Sale(Predicate<Book> method)
        {
            List<Book> products=_libraryRepository.FindAll(method);
            if (products.Count == 0)
            {
                Console.WriteLine("Mehsul tapilmadi!!!");
            }
            decimal totalPrice = products.Sum(x => x.Price);
            if (totalPrice >100)
            {
                totalPrice = totalPrice - (totalPrice * 10 / 100);
            }
            else if(totalPrice > 200)
            {
                totalPrice = totalPrice - (totalPrice * 10 / 100);
            }
           
            Order order = new Order
            {
                books = products,
                Data = DateTime.Now,
                TotalPrice = totalPrice
            };
            return order;
        }
    }
}
