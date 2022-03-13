using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_evidencija
{
    internal class Grad
    {
        private string nazivGrada;
        private Drzava drzava;

        public string NazivGrada
        {
            get { return nazivGrada; }  
        }

        public string Drzava
        {
            get { return drzava.NazivDrzave; }
        }

        public Grad(Drzava drzava, string nazivGr)
        {
            this.nazivGrada = nazivGr;
            this.drzava = drzava;
        }
    }
}
