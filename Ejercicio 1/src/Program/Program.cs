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
        }
    
    }
}
