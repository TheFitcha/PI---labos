using BankaLib;
using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public abstract class Korisnik : IKorisnik
    {
        public abstract string Opis { get; }
        public VrstaKorisnika Vrsta { get; protected set; }
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<IRacun> Racuni { get ; set; }

        public Korisnik(string oib, string ime, string prezime)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            Racuni = new List<IRacun>();
        }

        public List<IRacun> DohvatiRacune()
        {
            return Racuni.ToList();
        }

        public List<IRacun> DohvatiRacune(VrstaRacuna vrsta)
        {
            var list = new List<IRacun>();

            foreach (var racun in Racuni)
            {
                if (racun.Vrsta == vrsta)
                {
                    list.Add(racun);
                }
            }

            return list;
        }

        public IRacun DohvatiRacun(string iban)
        {
            IRacun racun = null;

            for (int i = 0; i < Racuni.Count; i++)
            {
                var trenutniRacun = Racuni[i];
                if (trenutniRacun.IBAN == iban)
                {
                    racun = trenutniRacun;
                }
            }

            return racun;
        }

        public void KreirajTekuciRacun(string iban, double stanje, double odobreniMinus = 0)
        {
            Racuni.Add(new TekuciRacun(iban, stanje, odobreniMinus));
        }

        public void KreirajDevizniRacun(string iban, double stanje, string oznakaValute)
        {
            Valuta valuta = MjenjacnicaDB.VratiValutuPoNazivu(oznakaValute);
            Racuni.Add(new DevizniRacun(iban, stanje, valuta));
        }
    }
}
