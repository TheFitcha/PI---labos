using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjačnica
{
    internal class TecajnaLista
    {
        private List<Tecaj> tecajna;
        public TecajnaLista()
        {
            tecajna = new List<Tecaj>()
            {
                new Tecaj("EUR", (float)7.5),
                new Tecaj("USD", (float)7.2)
            };
        }
        public List<Tecaj> tecajnaLista
        {
            get { return tecajna; }
        }
        public void DodajTecaj(string naziv, float vrijednost)
        {
            tecajnaLista.Add(new Tecaj(naziv, vrijednost));
        }

        public void UkloniTecaj(string naziv)
        {
            tecajnaLista.Remove(tecajnaLista.Find(x => x.Naziv == naziv));
        }
    }
}
