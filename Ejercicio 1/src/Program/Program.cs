using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            Shelve shelve1 = new Shelve("1");
            Shelve shelve2 = new Shelve("2");

            book1.AssignToShelve(shelve1);
            book2.AssignToShelve(shelve2);

            Sector sector1 = new Sector("A");
            Sector sector2 = new Sector("B");

            sector1.AddShelve(shelve1);
            sector2.AddShelve(shelve2);

            Console.WriteLine($"Libro 1: {book1.Title}");
            Console.WriteLine($"Autor: {book1.Author}");
            Console.WriteLine($"Código: {book1.Code}");
            Console.WriteLine($"El libro 1 se encuentra en el sector {sector1.Nombre} y en el estante {shelve1.Num}");

            Console.WriteLine($"Libro 2: {book2.Title}");
            Console.WriteLine($"Autor: {book2.Author}");
            Console.WriteLine($"Código: {book2.Code}");
            Console.WriteLine($"El libro 2 se encuentra en el sector {sector2.Nombre} y en el estante {shelve2.Num}");

            
            foreach (var book in shelve2.Books)
            {
                Console.WriteLine($"Los libros que hay en el estante {shelve2.Num} son: {book.Title}");
            }
        }
    }
}