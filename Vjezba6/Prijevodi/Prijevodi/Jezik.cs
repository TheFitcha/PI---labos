using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijevodi
{
    public class Jezik
    {
        public string Naziv { get; set; }
        public Jezik(string naziv)
        {
            Naziv = naziv;
        }
    }
}
