using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public enum StatusRacuna
    {
        Aktivan, Neaktivan
    }

    public interface IRacun
    {
        string IBAN { get; }
        double Stanje { get; }
        VrstaRacuna Vrsta { get; }
        Valuta Valuta { get; }

        void DodajIznos(double iznos);
        void ZabiljeziTransakciju(Transakcija transakcija);
        void OduzmiIznos(double iznos);
        void UkloniTransakciju(Transakcija transakcija);
        void IzvrsiIsplatu(IRacun odredisniRacun, double iznos);
        List<Transakcija> VratiSveTransakcije();
    }
}
