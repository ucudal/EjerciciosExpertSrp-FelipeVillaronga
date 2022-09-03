using System;
using System.Collections.Generic;
using SRP;

namespace SRP
{

    class Program
    {
        public static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            book1.BookList();
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");
            book2.BookList();
            ShelveBook shelve1 = new ShelveBook("A", "7");
            shelve1.BookLocationList();
            ShelveBook shelve2 = new ShelveBook("B", "3");
            shelve2.BookLocationList();
            Console.WriteLine(book1.BookPrinter());
            shelve1.shelvePrinter();
            Console.WriteLine(book2.BookPrinter());
            shelve2.shelvePrinter();
            Dictionary<List<string>,List<string>> BooksWithShelves= new Dictionary<List<string>,List<string>> {{book1.bookData, shelve1.bookLocationData}, {book2.bookData, shelve2.bookLocationData}};
            BookAndShelve bookAndShelves = new BookAndShelve(BooksWithShelves);
        }
    }
}
