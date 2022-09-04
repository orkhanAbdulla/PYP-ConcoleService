using PHP_ConsoleApp.Entities;
using PHP_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Services.Interfaces
{
    public interface IOrderService
    {
        public Order Sale(Predicate<Book> method);
    }
}
