namespace VerificaGIT
{
    internal class Program
    {
        public static void Menu()
        {
        

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
            Console.WriteLine("Quanti libri vuole aggiungere?\n> ");
            int numerolibri;
            while (int.TryParse(Console.ReadLine(), out numerolibri))
            {
                Console.WriteLine("Inserisca un valore valido\n> ");
            }
            for(int i = 0; i< numerolibri; i++)
            {
                Console.WriteLine("Inserisca il nome del libro\n> ");
                string nomelibro = Console.ReadLine();
                Console.WriteLine("Inserire il titolo del libro\n> ");
                string titololibro = Console.ReadLine();
                Console.WriteLine("Inserire solo l'anno di pubblicazione\n> ");
                int annolibro;
                while (int.TryParse(Console.ReadLine(), out annolibro))
                {
                    Console.WriteLine("Inserisca un valore valido\n> ");
                }
                Console.WriteLine("Inserire l'editore del libro\n> ");
                string editorelibro  = Console.ReadLine();
                Console.WriteLine("Inserire quante pagine ha questo libro\n> ");
                int paginelibro;
                while (int.TryParse(Console.ReadLine(), out paginelibro))
                {
                    Console.WriteLine("Inserisca un valore valido\n> ");
                }
                Libro libro = new Libro(nomelibro,titololibro, annolibro,editorelibro,paginelibro);
                biblioteca.NuovoLibro(libro);
            }
            
        }
    }
}
