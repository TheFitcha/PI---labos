using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class Tecaj
    {
        public Valuta Valuta { get; set; }
        public double Vrijednost { get; set; }

        public Tecaj(Valuta valuta, double vrijednost)
        {
            Valuta = valuta;
            Vrijednost = vrijednost;
        }
    }
}
