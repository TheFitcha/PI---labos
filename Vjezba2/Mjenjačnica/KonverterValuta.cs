using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjačnica
{
    internal class KonverterValuta
    {
        public float Konvertiraj(float vrijednostHRK, Tecaj tecaj)
        {
            return vrijednostHRK / tecaj.Vrijednost;
        }
    }
}
