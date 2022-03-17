using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe_proizvoda
{
    internal class Proizvod
    {
        private string naziv;
        private float jedCijena;
        private int stanje;
        public Proizvod(string naziv, float jedCijena, int stanje)
        {
            this.naziv = naziv;
            this.jedCijena = jedCijena;
            this.stanje = stanje;
        }
        public string Naziv 
        { get { return naziv; } }
        public float IzracunajVrijednostZaliha()
        {
            return jedCijena * stanje;
        }
        public void DodajNaStanje(int kolicina)
        {
            if(kolicina <= 0)
            {
                Console.WriteLine("Kolicina ne moze biti 0 ili negativna!");
                return;
            }
            stanje += kolicina;
        }
        public void OduzmiSaStanja(int kolicina)
        {
            if(kolicina <= 0)
            {
                Console.WriteLine("Kolicina ne moze biti 0 ili negativna!");
                return;
            }
            else if(kolicina > stanje)
            {
                Console.WriteLine("Ne postoji toliko proizvoda na skladistu!");
                return;
            }
            stanje -= kolicina; 
        }

        public string DohvatiIspis()
        {
            return $"{naziv} - {jedCijena} - {stanje} kom";
        }
    }
}
