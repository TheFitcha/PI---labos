using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijevodi
{
    public class Rijec
    {
        public string OriginalnaRijec { get; set; }
        public string PrijevodRijeci { get; set; }
        public Rijec(string original, string prijevod)
        {
            OriginalnaRijec = original;
            PrijevodRijeci = prijevod;
        }
    }
}
