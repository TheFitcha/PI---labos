using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobneFinancije
{
    internal class Envelope
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public Envelope(string name, double money)
        {
            Name = name;
            Money = money;
        }
    }
}
