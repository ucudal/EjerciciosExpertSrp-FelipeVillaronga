using System;
using System.Collections.Generic;

namespace SRP;
   public class ShelveBook
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set;  }
        public ShelveBook(string LibrarySector, string LibraryShelve)
        {
            this.LibrarySector = LibrarySector;
            this.LibraryShelve = LibraryShelve;
        }

        public List <string> bookLocationData= new List<string> ();
        public void BookLocationList()
        {
            bookLocationData.Add(LibrarySector);
            bookLocationData.Add(LibraryShelve);
        }
        public void shelvePrinter()
        {
            Console.WriteLine($"Sector: {LibrarySector}. \nEstanteria: {LibraryShelve}.");
        }
        
    }
    /*De surgir la necesidad de modificar el metodo ShelveBook, 
    a modo de ejemplo, crear una nueva variable "edificio" o "departamento", 
    se crearia una segunda razon para modificar la clase Book; lo cual contradice el principio SRP.
    Por ello es necesario crear una nueva clase -ShelveBook- en la cual, ahora sí, 
    definir las variables LibrarySector y LibraryShelve; fijando en esta, como única responsabilidad, 
    conocer y definir las ubicaciones de los libros.
    */