namespace VerificaGIT
{
    internal class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1. Vedere quanti libri ci sono in biblioteca");
            Console.WriteLine("2. Ricercare un libro per titolo");
            Console.WriteLine("3. Ricercare tutti i libro di un autore");
            Console.WriteLine("4. Esci dalla gestione");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Salve benvenuto nella gestione biblioteca!");
            Console.WriteLine("Inserire le info della biblioteca");
            Console.Write("Nome>");
            string nomebiblioteca = Console.ReadLine();
            Console.Write("Indirizzo> ");
            string indirizzobiblioteca = Console.ReadLine();
            Console.Write("Orario di apertura> ");
            string aperturabiblioteca = Console.ReadLine();
            Console.Write("Orario di chiusura> ");
            string chiusurabiblioteca = Console.ReadLine();
            Biblioteca biblioteca  = new Biblioteca(nomebiblioteca,indirizzobiblioteca,aperturabiblioteca,chiusurabiblioteca);
            Console.WriteLine("Biblioteca registrata");
            Console.Write("Quanti libri vuole aggiungere?\n> ");
            int numerolibri;
            while (!int.TryParse(Console.ReadLine(), out numerolibri))
            {
                Console.Write("Inserisca un valore valido\n> ");
            }
            for(int i = 0; i< numerolibri; i++)
            {
                Console.Write("Inserisca l'autore del libro\n> ");
                string nomelibro = Console.ReadLine();
                Console.Write("Inserire il titolo del libro\n> ");
                string titololibro = Console.ReadLine();
                Console.Write("Inserire solo l'anno di pubblicazione\n> ");
                int annolibro;
                while (!int.TryParse(Console.ReadLine(), out annolibro))
                {
                    Console.Write("Inserisca un valore valido\n> ");
                }
                Console.Write("Inserire l'editore del libro\n> ");
                string editorelibro  = Console.ReadLine();
                Console.Write("Inserire quante pagine ha questo libro\n> ");
                int paginelibro;
                while (!int.TryParse(Console.ReadLine(), out paginelibro))
                {
                    Console.Write("Inserisca un valore valido\n> ");
                }
                Libro libro = new Libro(nomelibro,titololibro, annolibro,editorelibro,paginelibro);
                
                biblioteca.NuovoLibro(libro);
                Console.WriteLine("Libro aggiunto alla biblioteca con successo, ecco alcune caratteristiche del libro: " + libro.toString() + " e quanto ci si mette a leggerlo " + libro.readingTime());
            }
            Console.WriteLine("Cosa vuoi fare?");
            Menu();
            string scelta = "0";
            while(scelta != "4")
            {
                scelta = Console.ReadLine();
                switch(scelta)
                {
                    case "1":
                        Console.WriteLine("Ci sono: " + biblioteca.NumeroLibri().ToString());
                        break;
                    case "2":
                        Console.Write("Inserisca il titolo per il quale si vuole cercare\n> ");
                        string titolo = Console.ReadLine();
                        Console.WriteLine(biblioteca.RicercaTitolo(titolo));
                        break;
                    case "3":
                        Console.Write("Inserire l'autore del quale si vogliono cercare i libri\n>");
                        string autore = Console.ReadLine();
                        List<Libro> libritrovati =
                        libritrovati = biblioteca.RicercaPerAutore(autore);
                        if(libritrovati.Count() == 0)
                        {
                            Console.WriteLine("Mi dispiace ma non abbiamo libri di questo autore in biblioteca");
                        } else
                        {
                            Console.WriteLine("Libri trovati:");
                            foreach(Libro libro in libritrovati)
                            {
                                Console.WriteLine(libro.toString());
                            }
                        }
                        break;
                    

                }
            }

            
        }
    }
}
