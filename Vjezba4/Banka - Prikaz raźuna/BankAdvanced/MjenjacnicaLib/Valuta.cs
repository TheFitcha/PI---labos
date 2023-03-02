using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class Valuta
    {
        public string Naziv { get; set; }
        public string Drzava { get; set; }

        public Valuta(string naziv, string drzava)
        {
            Naziv = naziv;
            Drzava = drzava;
        }

        public override string ToString()
        {
            return $"{Naziv} ({Drzava})";
        }
    }
}
