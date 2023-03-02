using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class KatalogFilmova
    {
        public List<Film> ListaSvihFilmova;
        public KatalogFilmova()
        {
            ListaSvihFilmova = new List<Film>();
        }
        public List<Film> DohvatiSveFilmove()
        {
            return ListaSvihFilmova;
        }
    }
}
