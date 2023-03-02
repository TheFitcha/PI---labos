using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijevodi
{
    public class Rjecnik
    {
        public List<Rijec> ListaRijeci;
        public Rjecnik()
        {
            ListaRijeci = new List<Rijec>();
        }

        public string Prevedi(string recenica)
        {
            var razdvojeno = recenica.Split(' ');
            string prijevodRecenice = string.Empty;
            foreach(var rijec in razdvojeno)
            {
                prijevodRecenice += PronadiPrijevod(rijec) + " ";
            }
            return prijevodRecenice;
        }

        private string PronadiPrijevod(string rijec)
        {
            string prijevod = null;
            try
            {
                Rijec zaPrijevod = ListaRijeci.Find(x => x.OriginalnaRijec == rijec);
                if(zaPrijevod != null)
                {
                    prijevod = zaPrijevod.PrijevodRijeci;
                }
                else
                {
                    prijevod = "X";
                }
            }
            catch
            {
                throw new Exception("Pogreska prilikom prevodenja!");
            }         
            return prijevod;
        }

        public void DodajNovuRijec(Rijec novaRijec)
        {
            ListaRijeci.Add(novaRijec);
        }
    }
}
