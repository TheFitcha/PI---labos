using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLib1
{
    internal class Projekcija
    {
        public DateTime Vrijeme { get; set; }
        public Dvorana KojaDvorana { get; set; }    
        public Film KojiFilm { get; set; }
        public bool Premijera { get; set; }
        public Projekcija(DateTime vrijeme, Dvorana dvorana, Film film, bool premijera)
        {
            Vrijeme = vrijeme;
            KojaDvorana = dvorana;
            KojiFilm = film;
            Premijera = premijera;
        }
    }
}
