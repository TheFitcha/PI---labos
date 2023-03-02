using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class TekuciRacun : Racun
    {
        public double OdobreniMinus { get; set; }
        public double RaspoloziviIznos
        {
            get { return IzracunajRaspoloziviIznos(); }
        }

        public TekuciRacun(string iban, double stanje, double odobreniMinus)
            : base(iban, stanje)
        {
            OdobreniMinus = odobreniMinus;
            Vrsta = VrstaRacuna.Tekuci;
            Valuta = MjenjacnicaDB.ReferentnaValuta;
        }

        public override void OduzmiIznos(double iznos)
        {
            Stanje -= iznos;
        }

        private double IzracunajRaspoloziviIznos()
        {
            double raspolozivo = OdobreniMinus + Stanje;
            return raspolozivo;
        }

        public override string ToString()
        {
            return $"IBAN:{IBAN}, Stanje:{Stanje}, Raspoloživo:{RaspoloziviIznos}";
        }
    }
}
