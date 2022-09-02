using System;
using SRP;

namespace SRP
{
    
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            ShelveBook shelve1= new ShelveBook (book1, "A","7"); 
            ShelveBook shelve2= new ShelveBook (book2, "B","3");
            BookAndShelve bookShelve1= new BookAndShelve (book1, shelve1);
            BookAndShelve bookShelve2= new BookAndShelve (book2, shelve2);
        }
        public void Printer ()
        {
            Console.WriteLine(book1.BookPrinter());
            Console.WriteLine(shelve1.BookShelvePrinter());
            Console.WriteLine(book2.BookPrinter());
            Console.WriteLine(shelve2.BookShelvePrinter());
    }
}
