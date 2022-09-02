using System;

namespace SRP
{
    public class Book
    {
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public string Title { get ; set; }
        public string Author { get ; set; }
        public string Code { get ; set; }
        
        public string BookPrinter ()
        {
            return $"Libro: "\{Title}\" ({Author}, Código: {Code}).";
        }
        
      /*public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
      */

    }
}
