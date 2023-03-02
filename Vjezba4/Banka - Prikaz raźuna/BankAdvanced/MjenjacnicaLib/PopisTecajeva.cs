using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class PopisTecajeva
    {
        private List<Tecaj> _tecaji = new List<Tecaj>();

        public PopisTecajeva()
        {
            Valuta aud = MjenjacnicaDB.VratiValutuPoNazivu("AUD");
            _tecaji.Add(new Tecaj(aud, 4.07));

            Valuta cad = MjenjacnicaDB.VratiValutuPoNazivu("CAD");
            _tecaji.Add(new Tecaj(cad, 4.9));

            Valuta chf = MjenjacnicaDB.VratiValutuPoNazivu("CHF");
            _tecaji.Add(new Tecaj(chf, 7.2));

            Valuta gbp = MjenjacnicaDB.VratiValutuPoNazivu("GBP");
            _tecaji.Add(new Tecaj(gbp, 8.2));

            Valuta usd = MjenjacnicaDB.VratiValutuPoNazivu("USD");
            _tecaji.Add(new Tecaj(usd, 7.1));

            Valuta bam = MjenjacnicaDB.VratiValutuPoNazivu("BAM");
            _tecaji.Add(new Tecaj(bam, 3.88));

            Valuta eur = MjenjacnicaDB.VratiValutuPoNazivu("EUR");
            _tecaji.Add(new Tecaj(eur, 7.6));

            Valuta hrk = MjenjacnicaDB.VratiValutuPoNazivu("HRK");
            _tecaji.Add(new Tecaj(hrk, 1));
        }

        public Tecaj VratiTecajZaValutu(Valuta valuta)
        {
            Tecaj tecaj = null;
            foreach (var t in _tecaji)
            {
                if (t.Valuta == valuta)
                {
                    tecaj = t;
                }
            }

            return tecaj;
        }

        public Tecaj VratiTecajZaValutu(string oznakaValute)
        {
            foreach (var t in _tecaji)
            {
                if (t.Valuta.Naziv == oznakaValute)
                {
                    return t;
                }
            }

            return null;
        }

        public List<Tecaj> VratiSveTecajeve()
        {
            return _tecaji.ToList();
        }

        public void KreirajNoviTecaj(Valuta valuta, double vrijednost)
        {
            if (_tecaji.Exists(t => t.Valuta == valuta) == false)
            {
                var tecaj = new Tecaj(valuta, vrijednost);
                _tecaji.Add(tecaj);
            }
        }
    }
}
