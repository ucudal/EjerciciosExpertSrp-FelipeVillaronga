using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
      /*public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
      */

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

      /*public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */
    }
    public class ShelveBook
    {
        public Book book { get; }
        //se debe llamar a la clase Book para poder acceder a la instancia que esta cree, y poder asociarla al sector y shelve fijado.
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        
        public void ShelveBook(Book book, String sector, String shelve)
        {
            this.book = book;
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
    // La clase Book, tenía dos constructores, y una clase puede tener un único método de clase. Asimismo, de surgir la necesidad de modificar el metodo ShelveBook (crear una nueva variable "edificio" o "departamento") se crearia una segunda razon para modificar la clase Book; lo cual contradice el principio SRP.
    //Por ello es necesario crear una nueva clase -ShelveBook- en la cual, ahora sí, crear un método constructor para los atributos LibrarySector y LibraryShelve
}
