using BankaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public interface IKorisnik
    {
        string Opis { get; }
        VrstaKorisnika Vrsta { get; }
        string OIB { get; }
        string Ime { get; }
        string Prezime { get;}
        List<IRacun> Racuni { get; set; }

        List<IRacun> DohvatiRacune();
        List<IRacun> DohvatiRacune(VrstaRacuna vrsta);
        IRacun DohvatiRacun(string iban);
        void KreirajTekuciRacun(string iban, double pocetnoStanje, double dozvoljeniMinus);
        void KreirajDevizniRacun(string iban, double stanje, string oznakaValute);
    }
}
