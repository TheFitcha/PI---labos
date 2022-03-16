using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Autentifikator
    {
        private List<Korisnik> listaKorisnika;
        public Autentifikator()
        {
            listaKorisnika = new List<Korisnik>()
            {
                new Korisnik("ivoivic3", "1111"),
                new Korisnik("markomarkic2", "2222"),
                new Korisnik("anaanic1", "3333")
            };
        }
        private Korisnik DohvatiKorisnika(string korisnickoIme)
        {
            return listaKorisnika.Find(x => x.KorisnickoIme == korisnickoIme);  
        }

        public string PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik logKorisnik = DohvatiKorisnika(korisnickoIme);
            if(logKorisnik == null)
            {
                return "Ne postoji korisnik sa navedenim korisnickim imenom!";
            }
            else if(logKorisnik.Lozinka != lozinka)
            {
                return "Pogresno upisana lozinka!";
            }
            else
            {
                return "Uspjesno prijavljen korisnik!";
            }
        }
    }
}
