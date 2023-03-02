using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public static class Autentifikator
    {
        private static List<KorisnickiRacun> KorisnickiRacuni;
        public static KorisnickiRacun PrijavljeniKorisnik { get; set; }

        static Autentifikator()
        {
            PopuniKorisnickeRacune();
        }

        private static void PopuniKorisnickeRacune()
        {
            KorisnickiRacuni = new List<KorisnickiRacun>();

            var pero = new Klijent("1111", "Pero", "Perić");
            var peroAuth = new KorisnickiRacun("pperic", "pero10", pero);
            KorisnickiRacuni.Add(peroAuth);

            var ivana = new Klijent("2222", "Ivana", "Lukić");
            var ivanaAuth = new KorisnickiRacun("ilukic", "ivana10", ivana);
            KorisnickiRacuni.Add(ivanaAuth);

            pero.KreirajRacun("HR1111", 8000);
            pero.KreirajRacun("HR1234", 2000);

            ivana.KreirajRacun("HR2222", 3500);
            ivana.KreirajRacun("HR2345", 1200);
        }

        public static void Odjavi()
        {
            PrijavljeniKorisnik = null;
        }

        public static void Prijavi(string korisnickoIme, string lozinka)
        {
            KorisnickiRacun korisnickiRacun = DohvatiKorisnickiRacun(korisnickoIme, lozinka);
            if (korisnickiRacun != null)
            {
                PrijavljeniKorisnik = korisnickiRacun;
            }
            else
            {
                PrijavljeniKorisnik = null;
            }
        }

        private static KorisnickiRacun DohvatiKorisnickiRacun(string korisnickoIme, string lozinka)
        {
            KorisnickiRacun korisnickiRacun = null;

            foreach (var k in KorisnickiRacuni)
            {
                if (k.KorisnickoIme == korisnickoIme)
                {
                    korisnickiRacun = k;
                    break;
                }
            }

            return korisnickiRacun;
        }
    }
}
