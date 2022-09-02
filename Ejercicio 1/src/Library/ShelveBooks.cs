using System;

namespace SRP;
   public class ShelveBook
    {
        public string LibrarySector { get ; }
        public string LibraryShelve { get ;  }
        public  ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        
        public string Printer2()
        {
            return $"Sector: {LibrarySector}. \nEstanteria: {LibraryShelve}.";
        }
        
    }
    // La clase Book, tenía dos constructores, y una clase puede tener un único método de clase. Asimismo, de surgir la necesidad de modificar el metodo ShelveBook (crear una nueva variable "edificio" o "departamento") se crearia una segunda razon para modificar la clase Book; lo cual contradice el principio SRP.
    //Por ello es necesario crear una nueva clase -ShelveBook- en la cual, ahora sí, crear un método constructor para los atributos LibrarySector y LibraryShelve
