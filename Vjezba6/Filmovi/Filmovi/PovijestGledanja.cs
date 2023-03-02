using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class PovijestGledanja
    {
        public List<PogledaniFilm> ListaPogledanihFilmova;
        public PovijestGledanja()
        {
            ListaPogledanihFilmova = new List<PogledaniFilm>();
        }
        public List<PogledaniFilm> DohvatiPogledaneFilmove()
        {
            return ListaPogledanihFilmova;
        }
    }
}
