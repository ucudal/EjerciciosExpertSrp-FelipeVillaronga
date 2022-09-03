using System;
using System.Collections.Generic;

namespace SRP
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Code { get; set; }

        public Book(string Title, string Author, string Code)
        {
            this.Title = Title;
            this.Author = Author;
            this.Code = Code;
        }
    
        public List<string> bookData = new List<string>();
        public void BookList()
        {
            bookData.Add(Title);
            bookData.Add(Author);
            bookData.Add(Code);
        }

        public string BookPrinter()
        {
            return $"Libro: \"{Title}\" ({Author}, Código: {Code}).";
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
