using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_evidencija
{
    internal class ZapisZarazenih
    {
        private DateTime vrijeme;
        private Grad grad;
        private int brojZarazenih;

        public DateTime Vrijeme
        {
            get { return vrijeme; }
        }
        public Grad Grad
        {
            get { return grad; }
        }
        public int BrojZarazenih
        {
            get { return brojZarazenih; }
        }

        public ZapisZarazenih(Grad grad, int brZarazenih)
        {
            this.vrijeme = DateTime.Now;
            this.grad = grad;
            this.brojZarazenih = brZarazenih;
        }
    }
}
