using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Knjiznica
    {
        private List<Knjiga> PopisKnjiga;
        public Knjiznica()
        {
            PopisKnjiga = new List<Knjiga>()
            {
                new Knjiga("Silmarilion"),
                new Knjiga("Hurin's children"),
                new Knjiga("Unfinished tales", false, "Pero Peric")
            };
        }
        public void Posudi(string naslov, string osoba)
        {
            Knjiga k = PopisKnjiga.Find(x => x.Naslov == naslov);   
            if(k == null)
            {
                Console.WriteLine("Knjiga ne postoji!");
                return;
            }
            if (k.Dostupno)
            {
                k.Dostupno = !k.Dostupno;
                k.Osoba = osoba;
            }
            else
            {
                Console.WriteLine("Knjiga nije dostupna!");
            }
            foreach(Knjiga knjiga in PopisKnjiga)
            {
                Console.WriteLine(knjiga.DohvatiOpis());
            }
        }
    }
}
