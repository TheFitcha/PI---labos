using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public class PremiumKorisnik : Korisnik
    {
        public string NazivPoduzeca { get; set; }

        public PremiumKorisnik(string oib, string nazivPoduzeca, string imeVlasnika, string prezimeVlasnika) : base(oib, imeVlasnika, prezimeVlasnika)
        {
            Vrsta = VrstaKorisnika.Premium;
            NazivPoduzeca = nazivPoduzeca;
        }

        public override string ToString()
        {
            return NazivPoduzeca;
        }

        public override string Opis
        {
            get { return $"{NazivPoduzeca}, vl. {Ime} {Prezime}"; }
        }
    }
}
