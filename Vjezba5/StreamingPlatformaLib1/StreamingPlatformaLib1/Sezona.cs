using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatformaLib1
{
    internal class Sezona
    {
        public int RedniBrojSezone { get; set; }
        public List<Epizoda> ListaEpizoda { get; set; }
        public Sezona(int redniBroj)
        {
            RedniBrojSezone = redniBroj;
            ListaEpizoda = new List<Epizoda>();
        }

        public void DodajEpizodu(Epizoda epizoda)
        {
            ListaEpizoda.Add(epizoda);
        }
      
    }
}
