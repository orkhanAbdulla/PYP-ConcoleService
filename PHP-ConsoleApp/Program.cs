using PHP_ConsoleApp.DAL;
using PHP_ConsoleApp.Models;
using PHP_ConsoleApp.Repositories.Implimentations;
using PHP_ConsoleApp.Repositories.Interfaces;
using PHP_ConsoleApp.Services;
using PHP_ConsoleApp.Services.Implimentations;
using PHP_ConsoleApp.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;


//Database
Library library = new Library("Libraff");

Book book = new Book("Ali ve nino", "Qurban Said", 30,85);
Book book1 = new Book("Voyna i mir", "L.N.Tolstoy", 40,70);
Book book2 = new Book("Yeddi gozel", "Nizami", 10,95);
Book book3 = new Book("Ali ve nino", "Qurban Said", 60,85);

Context context = new Context(library);

//Dependency Injection 
ILibraryRepository libraryRepository = new LibraryRepository(context);
ILibraryService libraryService = new LibraryService(libraryRepository);
IOrderService orderService = new OrderService(libraryRepository);


libraryService.AddBook(book);
libraryService.AddBook(book1);
libraryService.AddBook(book2);
libraryService.AddBook(book3);
libraryService.ShowBooks();
Console.WriteLine("---------------------------------------------------------------");

//Order
var order=orderService.Sale(x=>x.Name== "Ali ve nino");
order.ShowSale();
Console.WriteLine("---------------------------------------------------------------");
var order1 = orderService.Sale(x => x.Name == "Yeddi gozel");
order1.ShowSale();

//Book getBook=libraryService.GetBook(x => x.Name == "Ali ve nino");


//List<Book> FindBooks = libraryService.FindAllBooks(x => x.Name == "Ali ve nino");
//foreach (var item in FindBooks)
//{
//    Console.WriteLine(item);
//}


//int count = libraryService.RemoveAllBooks(x=>x.Name== "Ali ve nino");
//Console.WriteLine(count);






