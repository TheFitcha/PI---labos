using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class KorisnickiRacun
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Klijent Klijent { get; set; }

        public KorisnickiRacun(string korisnickoIme, string lozinka, Klijent klijent)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Klijent = klijent;
        }

    }
}
