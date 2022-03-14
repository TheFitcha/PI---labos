using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiznica
    {
        private List<Knjiga> knjige;
        private List<Posudba> posudbe;
        public Knjiznica()
        {
            knjige = new List<Knjiga>()
            {
                new Knjiga("1111", "Beren and Luthien"),
                new Knjiga("2222", "Fall of Gondolin"),
                new Knjiga("3333", "Hobbit")
            };
            posudbe = new List<Posudba>();
        }

        public Posudba PosudiKnjigu(string osoba, string isbn)
        {
            Posudba novaPosudba = new Posudba(osoba, knjige.Find(x => x.ISBN == isbn));
            posudbe.Add(novaPosudba);
            return novaPosudba;
        }
    }
}
