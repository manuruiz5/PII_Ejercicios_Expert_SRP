using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace SRP
{
    public class Shelve
    {
        public List<Book>Books { get; } = new List<Book>();
        public string Num { get; }

        public Shelve (string num)
        {
            this.Num = num;
        }
        public void AddBook (Book book)
        {
            Books.Add(book);
        }
      
    }
}