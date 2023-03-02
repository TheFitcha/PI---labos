using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatformaLib1
{
    public class Epizoda
    {
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public Epizoda(string naziv, int trajanje)
        {
            Naziv = naziv;
            Trajanje = trajanje;
        }
    }
}
