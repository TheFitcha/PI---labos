using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrosnja_energije
{
    internal class Kuca
    {
        private List<Brojilo> brojila;
        public Kuca()
        {
            brojila = new List<Brojilo>
            {
                new Brojilo("HEP_101", TipBrojila.Struja, 34235, 32150),
                new Brojilo("TP_222", TipBrojila.Plin, 11500, 10400),
                new Brojilo("VAR_123", TipBrojila.Voda, 16225, 16100)
            };
        }

        public List<Brojilo> Brojila
        {
            get { return brojila; }
        }

        private double DohvatiCijenuEnergenta(TipBrojila tip)
        {
            switch (tip)
            {
                case TipBrojila.Voda:
                    return 3.5;
                case TipBrojila.Plin:
                    return 0.2;
                case TipBrojila.Struja:
                    return 0.1;
            }
            return -1;
        }
        public double IzracunajIznosZaBrojilo(Brojilo brojilo)
        {
            return brojilo.OcitajPotrosnju() * DohvatiCijenuEnergenta(brojilo.Tip);
        }

        public double IzracunajIznosUkupno()
        {
            double ukupno = 0;
            foreach(Brojilo b in brojila)
            {
                ukupno += IzracunajIznosZaBrojilo(b);
            }
            return ukupno;
        }
    }
}
