using System;

namespace SRP;
   public class ShelveBook
    {
        public Book book { get; }
        //se debe llamar a la clase Book para poder acceder a la instancia que esta cree, y poder asociarla al sector y shelve fijado.
        public string LibrarySector { get ; }
        public string LibraryShelve { get ;  }
        public  ShelveBook(Book book, String sector, String shelve)
        {
            this.book = book;
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        
    }
