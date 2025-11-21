using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGIT
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; }
        public string OrarioChiusura { get; set; }
        public List<Libro> ListaLibro { get; set; }

        public Biblioteca(string name,string address,string open,string close)
        {
            Nome = name;
            Indirizzo = address;
            OrarioApertura = open;
            OrarioChiusura = close;
            ListaLibro = new List<Libro>();
        }
        public void NuovoLibro(Libro libro)
        {
            ListaLibro.Add(libro);
            Console.WriteLine("Libro aggiunto alla libreria");
        }
        public string RicercaTitolo(string titoloLibro)
        {
            foreach(Libro libro in ListaLibro)
            {
                if(libro.Titolo == titoloLibro)
                {
                    return libro.toString();
                }
            }
            return "Non è stato trovato nessun libro con questo titolo";
           
        }
        public List<Libro> RicercaPerAutore(string autoreLibro)
        {
            List<Libro> libriAutore = new List<Libro>();
            foreach(Libro libro in ListaLibro)
            {
                if(libro.Autore == autoreLibro)
                {
                    libriAutore.Add(libro);
                }
            }
            return libriAutore;
        }
        public int NumeroLibri()
        {
            return ListaLibro.Count();
        }

    }
}
