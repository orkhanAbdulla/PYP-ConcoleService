using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.Models
{
    public class Book
    {
        public string Code { get; set; }
        private static int _code;
        public Book(string name, string atuthname, int pageCount, decimal price)
        {
            Name = name;
            Atuthname = atuthname;
            PageCount = pageCount;
            Price = price;
            Code = generateCode(Name);
        }

        public string Name { get; set; }
        public string Atuthname { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"BookName:{Name} Author:{Atuthname} Price:{Price} Code:{Code}";
        }
        public string generateCode(string name)
        {
            var code = name.Split(" ");
            string result="";
            foreach (var item in code)
            {
                result += item[0];
            }
            ++_code;
            return result.ToUpper() +"-"+_code;
        }



    }
}
