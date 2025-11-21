using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGIT
{
    internal class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public int AnnoDiPubblicazione { get; set; }
        public string Editore  { get; set; }
        public int NumeroPagine { get; set; }
        public Libro(string author, string title, int year, string editor,int pages)
        {
            Autore = author;
            Titolo = title;
            AnnoDiPubblicazione = year;
            Editore = editor;
            NumeroPagine = pages;
        }
        public string toString()
        {
            return "Autore: " + Autore + ", Titolo: " + Titolo + ", Anno di pubblicazione: " + AnnoDiPubblicazione.ToString() + ", Editore: " + Editore + ", Numero pagine: " + NumeroPagine.ToString(); 
        }
        public string readingTime()
        {
            if (NumeroPagine < 100)
            {
                return "1h";
            } else if (NumeroPagine >= 100 && NumeroPagine <= 200) {
                return "2h";
            }else if (NumeroPagine > 200)
            {
                return "piu di 2h";
            }
            return "0h";

        }
    }
}
