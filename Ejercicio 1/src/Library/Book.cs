using System;
using System.Security.AccessControl;

namespace SRP
{
    public class Book   //No podemos facilmente reutilizar este clase 
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //public string LibrarySector { get ; set; } // No es responsabilidad del libro conocer esto
       // public string LibraryShelve { get ; set; } 

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
