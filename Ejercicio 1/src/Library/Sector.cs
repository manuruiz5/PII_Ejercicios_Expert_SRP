using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace SRP
{
    public class Sector
    {
        public string Nombre { get; }
        public List <Shelve> Shelves{ get; } = new List<Shelve>();
        public Sector (string nombre)
        {
            this.Nombre = nombre;
        }
        public void AddShelve (Shelve shelve)
        {
            Shelves.Add (shelve);
        }
    }

}