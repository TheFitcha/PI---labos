using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public abstract class Racun : IRacun
    {
        public string IBAN { get; set; }
        public double Stanje { get; set; }

        public VrstaRacuna Vrsta { get; set; }
        public Valuta Valuta { get; set; }
        private List<Transakcija> ProvedeneTransakcije { get; set; }

        public Racun(string iban, double stanje)
        {
            IBAN = iban;
            Stanje = stanje;

            ProvedeneTransakcije = new List<Transakcija>();
        }

        public Racun()
        {

        }

        public void IzvrsiIsplatu(IRacun odredisniRacun, double iznos)
        {
            provjeriIznos(iznos);
            Transakcija transakcija = new Transakcija(this, odredisniRacun, iznos);
            transakcija.Izvrsi();

            ZabiljeziTransakciju(transakcija);
            odredisniRacun.ZabiljeziTransakciju(transakcija);

            if (transakcija.Provedena == false)
            {
                transakcija.Ponisti();
            }
        }

        private void provjeriIznos(double iznos)
        {
            if(iznos < 0)
            {
                throw new TransactionException("Vrijednost ne moze biti negativna!");
            }
        }

        public virtual void DodajIznos(double iznos)
        {
            double novoStanje = Stanje + iznos;
            Stanje = Math.Round(novoStanje, 2);
        }

        public void ZabiljeziTransakciju(Transakcija transakcija)
        {
            ProvedeneTransakcije.Add(transakcija);
        }

        public virtual void OduzmiIznos(double iznos)
        {
            double novoStanje = Stanje - iznos;
            Stanje = Math.Round(novoStanje, 2);
        }

        public void UkloniTransakciju(Transakcija transakcija)
        {
            ProvedeneTransakcije.Remove(transakcija);
        }

        public List<Transakcija> VratiSveTransakcije()
        {
            return ProvedeneTransakcije.ToList();
        }

        public override string ToString()
        {
            return IBAN;
        }
    }
}
