using BankaLib;
using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public static class KorisniciDB
    {
        static KorisniciDB()
        {
            Korisnici = new List<IKorisnik>();
            var korisnik1 = new ObicniKorisnik("1111111111111", "Pero", "Perić");
            TekuciRacun racun11 = new TekuciRacun("HR11", 12000, 0);
            korisnik1.Racuni.Add(racun11);
            DevizniRacun racun51 = new DevizniRacun("HR51", 1000, MjenjacnicaDB.VratiValutuPoNazivu("EUR"));
            korisnik1.Racuni.Add(racun51);
            Korisnici.Add(korisnik1);
            DevizniRacun racun52 = new DevizniRacun("HR52", 500, MjenjacnicaDB.VratiValutuPoNazivu("USD"));
            korisnik1.Racuni.Add(racun52);

            var korisnik2 = new ObicniKorisnik("2222222222222", "Ivana", "Lukić");
            TekuciRacun racun12 = new TekuciRacun("HR12", 8000, 0);
            korisnik2.Racuni.Add(racun12);
            DevizniRacun racun53 = new DevizniRacun("HR53", 800, MjenjacnicaDB.VratiValutuPoNazivu("CHF"));
            korisnik2.Racuni.Add(racun53);
            DevizniRacun racun54 = new DevizniRacun("HR54", 700, MjenjacnicaDB.VratiValutuPoNazivu("BAM"));
            korisnik2.Racuni.Add(racun54);
            Korisnici.Add(korisnik2);

            var korisnik3 = new ObicniKorisnik("3333333333333", "Luka", "Novak");
            TekuciRacun racun13 = new TekuciRacun("HR13", 9000, 5000);
            korisnik3.Racuni.Add(racun13);
            DevizniRacun racun55 = new DevizniRacun("HR55", 800, MjenjacnicaDB.VratiValutuPoNazivu("EUR"));
            korisnik3.Racuni.Add(racun55);
            Korisnici.Add(korisnik3);

            var korisnik4 = new ObicniKorisnik("4444444444444", "Marko", "Horvat");
            TekuciRacun racun14 = new TekuciRacun("HR14", 3200, 3000);
            korisnik4.Racuni.Add(racun14);
            DevizniRacun racun56 = new DevizniRacun("HR56", 700, MjenjacnicaDB.VratiValutuPoNazivu("EUR"));
            korisnik4.Racuni.Add(racun56);
            Korisnici.Add(korisnik4);

            var korisnik5 = new ObicniKorisnik("5555555555555", "Marija", "Perić");
            TekuciRacun racun15 = new TekuciRacun("HR15", 6500, 2000);
            korisnik5.Racuni.Add(racun15);
            DevizniRacun racun57 = new DevizniRacun("HR57", 4000, MjenjacnicaDB.VratiValutuPoNazivu("EUR"));
            korisnik5.Racuni.Add(racun57);
            Korisnici.Add(korisnik5);

            PremiumKorisnik korisnik6 = new PremiumKorisnik("6666666666666", "Alfa d.o.o.", "Davor", "Majić");
            TekuciRacun racun16 = new TekuciRacun("HR16", 100000, 0);
            korisnik6.Racuni.Add(racun16);
            DevizniRacun racun58 = new DevizniRacun("HR58", 500, MjenjacnicaDB.VratiValutuPoNazivu("USD"));
            korisnik6.Racuni.Add(racun58);
            Korisnici.Add(korisnik6);

            PremiumKorisnik korisnik7 = new PremiumKorisnik("7777777777777", "Beta d.o.o.", "Ivan", "Ivanović");
            TekuciRacun racun17 = new TekuciRacun("HR17", 111500, 0);
            korisnik7.Racuni.Add(racun17);
            DevizniRacun racun59 = new DevizniRacun("HR59", 800, MjenjacnicaDB.VratiValutuPoNazivu("CHF"));
            korisnik7.Racuni.Add(racun59);
            Korisnici.Add(korisnik7);
            
            PremiumKorisnik korisnik8 = new PremiumKorisnik("8888888888888", "Gama d.o.o.", "Ana", "Horvat");
            TekuciRacun racun18 = new TekuciRacun("HR18", 80000, 0);
            korisnik8.Racuni.Add(racun18);
            DevizniRacun racun60 = new DevizniRacun("HR60", 700, MjenjacnicaDB.VratiValutuPoNazivu("BAM"));
            korisnik8.Racuni.Add(racun60);
            Korisnici.Add(korisnik8);
            
            PremiumKorisnik korisnik9 = new PremiumKorisnik("9999999999999", "Delta d.o.o.", "Marta", "Klarić");
            TekuciRacun racun19 = new TekuciRacun("HR19", 60000, 0);
            korisnik9.Racuni.Add(racun19);
            DevizniRacun racun61 = new DevizniRacun("HR61", 800, MjenjacnicaDB.VratiValutuPoNazivu("EUR"));
            korisnik9.Racuni.Add(racun61);
            Korisnici.Add(korisnik9);

            PremiumKorisnik korisnik10 = new PremiumKorisnik("1000000000000", "Omega d.o.o.", "Igor", "Lukić");
            TekuciRacun racun20 = new TekuciRacun("HR20", 6500, 0);
            korisnik10.Racuni.Add(racun20);
            DevizniRacun racun62 = new DevizniRacun("HR62", 700, MjenjacnicaDB.VratiValutuPoNazivu("EUR"));
            korisnik10.Racuni.Add(racun62);
            Korisnici.Add(korisnik10);

            racun11.IzvrsiIsplatu(racun12, 550);
            racun11.IzvrsiIsplatu(racun13, 1200);
            racun12.IzvrsiIsplatu(racun13, 800);
            racun13.IzvrsiIsplatu(racun14, 220);
            racun14.IzvrsiIsplatu(racun51, 450);
            racun51.IzvrsiIsplatu(racun52, 150);
            racun52.IzvrsiIsplatu(racun53, 150);
            
        }

        public static object VratiSveTransakcije()
        {
            var sveTransakcije = new List<Transakcija>();

            foreach (var k in Korisnici)
            {
                foreach (var r in k.Racuni)
                {
                    foreach (var t in r.VratiSveTransakcije())
                    {
                        if (sveTransakcije.Contains(t) == false)
                        {
                            sveTransakcije.Add(t);
                        }
                    }
                }
            }

            return sveTransakcije;
        }

        public static List<IKorisnik> Korisnici { get; private set; }

        public static List<IKorisnik> VratiSveKorisnike()
        {
            return Korisnici.ToList();
        }

        public static IKorisnik DohvatiKorisnika(string oib)
        {
            return Korisnici.FirstOrDefault(k => k.OIB == oib);
        }

        public static IKorisnik KreirajPremiumKorisnika(string oib, string poduzece, string ime, string prezime)
        {
            var korisnik = new PremiumKorisnik(oib, poduzece, ime, prezime);
            Korisnici.Add(korisnik);
            return korisnik;
        }

        public static IKorisnik KreirajObicnogKorisnika(string oib, string ime, string prezime)
        {
            var korisnik = new ObicniKorisnik(oib, ime, prezime);
            Korisnici.Add(korisnik);
            return korisnik;
        }
    }
}
