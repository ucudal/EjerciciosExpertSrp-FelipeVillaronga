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

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ; }
        
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
