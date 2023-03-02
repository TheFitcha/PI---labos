using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    public class BankaException : ApplicationException
    {
        public string Poruka { get; set; }

        public BankaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
