using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Knjiznica
    {
        private List<Knjiga> popisKnjiga;
        public Knjiznica()
        {
            popisKnjiga = new List<Knjiga>()
            {
                new Knjiga("1111", "Prstenova druzina", Status.Dostupno),
                new Knjiga("2222", "Dvije kule", Status.Dostupno),
                new Knjiga("3333", "Povratak kralja", Status.NaPosudbi)
            };
        }

        public Knjiga DohvatiKnjigu(string isbn)
        {
            return popisKnjiga.Find(x => x.ISBN == isbn);   
        }

        public void Posudi(string isbn)
        {
            Knjiga k = DohvatiKnjigu(isbn);
            if(k == null)
            {
                Console.WriteLine("Knjiga ne postoji!");
                return;
            }
            if(k.StatusKnjige == Status.Dostupno)
            {
                k.StatusKnjige = Status.NaPosudbi;
                Console.WriteLine("POSUDENO!");
            }
            else
            {
                Console.WriteLine("Knjiga je vec posudena!");
            }
            Console.WriteLine($"-----------------\nISBN: {k.ISBN}\nNaslov: {k.Naslov}\nStatus: {k.StatusKnjige}\n-----------------");
        }

    }

}
