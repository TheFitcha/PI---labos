using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Korisnik
    {
        private string korisnickoIme, lozinka;
        public Korisnik(string korisnickoIme, string lozinka)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }

        public string KorisnickoIme
        {
            get { return korisnickoIme; }
        }
        public string Lozinka
        {
            get { return lozinka; }
        }
    }
}
