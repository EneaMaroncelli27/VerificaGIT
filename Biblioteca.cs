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
        }

    }
}
