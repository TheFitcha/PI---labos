using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class Racun
    {
        public string IBAN { get; set; }
        public double Stanje { get; set; }
        private List<Transakcija> Transakcije { get; set; }

        public Racun(string iban, double stanje)
        {
            IBAN = iban;
            Stanje = stanje;
            Transakcije = new List<Transakcija>();
        }

        public void Isplati(string ibanPrimatelja, double iznos)
        {
            if (Stanje >= iznos)
            {
                var isplata = new Isplata(this, ibanPrimatelja, iznos);
                isplata.Provedi();
                Transakcije.Add(isplata);
            }
            else
            {
                throw new TransactionException("Iznos isplate je veci od stanja racuna!");
            }
        }

        public void Uplati(string ibanPlatitelja, double iznos)
        {
            var uplata = new Uplata(this, ibanPlatitelja, iznos);
            uplata.Provedi();
            Transakcije.Add(uplata);
        }

        public List<Transakcija> DohvatiSveTransakcije()
        {
            return Transakcije.ToList();
        }

        public override string ToString()
        {
            return IBAN;
        }
    }
}
