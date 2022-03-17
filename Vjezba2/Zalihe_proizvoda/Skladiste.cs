using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe_proizvoda
{
    internal class Skladiste
    {
        private List<Proizvod> listaProizvoda = new List<Proizvod>();
        public void DodajProizvod(string nazivNovog, float jedCijena, int kolicina)
        {
            if(listaProizvoda.Find(x => x.Naziv == nazivNovog) == null)
            {
                listaProizvoda.Add(new Proizvod(nazivNovog, jedCijena, kolicina));
            }
            else
            {
                Console.WriteLine("Vec postoji takav proizvod!");
            }
        }
        public void UkloniProizvod(Proizvod proizvod)
        {
            listaProizvoda.Remove(proizvod);
        }
        public Proizvod DohvatiProizvod(string naziv)
        {
            return listaProizvoda.Find(x => x.Naziv.Equals(naziv));
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            return listaProizvoda;
        }

        private float IzracunajUkupnuVrijednostZaliha()
        {
            float cijena = 0;
            foreach(Proizvod proizvod in listaProizvoda)
            {
                cijena += proizvod.IzracunajVrijednostZaliha();
            }
            return cijena;
        }
        public void PovecajKolicinuProizvoda(string naziv, int kolicina)
        {
            listaProizvoda.Find(x => x.Naziv == naziv).DodajNaStanje(kolicina);
        }
        public void OduzmiKolicinuProizvoda(string naziv, int kolicina)
        {
            listaProizvoda.Find(x => x.Naziv == naziv).OduzmiSaStanja(kolicina);
        }

        public void IspisiCijeloSkladiste()
        {
            foreach(Proizvod p in listaProizvoda)
            {
                Console.WriteLine(p.DohvatiIspis());
            }
            Console.WriteLine("Ukupna vrijednost: " + IzracunajUkupnuVrijednostZaliha());
        }
    }
}
