using PHP_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_ConsoleApp.DAL
{
    public class Context
    {
        public readonly Library _library;
        public Context(Library library)
        {
            _library=library;
        }
        
    }
}
