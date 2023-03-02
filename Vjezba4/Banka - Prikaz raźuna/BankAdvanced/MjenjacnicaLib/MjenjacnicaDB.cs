using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public static class MjenjacnicaDB
    {
        public static Valuta ReferentnaValuta { get; set; }

        static MjenjacnicaDB()
        {
            Valute = new List<Valuta>();

            Valute.Add(new Valuta("AUD", "Australija"));
            Valute.Add(new Valuta("CAD", "Kanada"));
            Valute.Add(new Valuta("CHF", "Švicarska"));
            Valute.Add(new Valuta("GBP", "V. Britanija"));
            Valute.Add(new Valuta("USD", "SAD"));
            Valute.Add(new Valuta("BAM", "BiH"));
            Valute.Add(new Valuta("EUR", "EMU"));
            Valute.Add(new Valuta("HRK", "Hrvatska"));
            
            PopisTecajeva = new PopisTecajeva();
            ReferentnaValuta = VratiValutuPoNazivu("HRK");
        }

        public static List<Valuta> Valute { get; private set; }

        public static Valuta VratiValutuPoNazivu(string nazivValute)
        {
            foreach (var v in Valute)
            {
                if (v.Naziv.ToLower() == nazivValute.ToLower())
                {
                    return v;
                }
            }

            return null;
        }

        public static void DodajNovuValutu(string naziv, string drzava)
        {
            var valuta = new Valuta(naziv, drzava);
            Valute.Add(valuta);
        }

        public static PopisTecajeva PopisTecajeva { get; set; }
    }
}
