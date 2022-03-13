using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_evidencija
{
    internal class Drzava
    {
        private string nazivDrzave;
        public string NazivDrzave 
        { 
            get { return nazivDrzave; } 
        }
        public Drzava(string naziv)
        {
            this.nazivDrzave = naziv;
        }
    }
}
