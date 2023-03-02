using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public class ObicniKorisnik : Korisnik
    {
        public ObicniKorisnik(string oib, string ime, string prezime)
            : base(oib, ime, prezime)
        {
            Vrsta = VrstaKorisnika.Obicni;
        }

        public override string Opis
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
