using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisZadataka
{
    public class Zadatak
    {
        public string Naziv { get; set; }
        public DateTime KrajnjiRok { get; set; }
        public Zadatak(string naziv, DateTime datum)
        {
            Naziv = naziv;
            KrajnjiRok = datum;
        }
        public bool TrebaObojati()
        {
            if(DateTime.Now.Subtract(KrajnjiRok).Days <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
