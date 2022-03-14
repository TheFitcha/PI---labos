using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    enum StatusSobe
    {
        Rezervirana,
        Slobodna
    }
    internal class Soba
    {
        private string oznaka;
        private int kapacitet;
        private StatusSobe statusSobe;
        public Soba(string oznaka, int kapacitet, StatusSobe statusSobe)
        {
            this.oznaka = oznaka;
            this.kapacitet = kapacitet;
            this.statusSobe = statusSobe;
        }
        public string Oznaka { get { return oznaka; } }
        public int Kapacitet { get { return kapacitet; } }
        public StatusSobe StatusSobe { 
            get { return statusSobe; }
            set { statusSobe = value; } 
        }
    }
}
