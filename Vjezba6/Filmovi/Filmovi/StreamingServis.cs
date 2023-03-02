using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class StreamingServis
    {
        public List<Film> ListaFilmova;
        private KatalogFilmova katalogFilmova;
        private PovijestGledanja povijestGledanja;
        public StreamingServis()
        {
            ListaFilmova = DohvatiZapoceteFilmove();
            katalogFilmova = new KatalogFilmova();
            povijestGledanja = new PovijestGledanja();
        }

        public List<Film> DohvatiZapoceteFilmove()
        {
            return (List<Film>) katalogFilmova.DohvatiSveFilmove().Intersect(povijestGledanja.DohvatiPogledaneFilmove());
        }
    }
}
