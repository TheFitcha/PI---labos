using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class Klijent
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<Racun> Racuni { get; set; }

        public Klijent(string oib, string ime, string prezime)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            Racuni = new List<Racun>();
        }

        public List<Racun> DohvatiSveRacune()
        {
            return Racuni.ToList();
        }

        public void KreirajRacun(string iban, double stanje)
        {
            Racuni.Add(new Racun(iban, stanje));
        }
    }
}
