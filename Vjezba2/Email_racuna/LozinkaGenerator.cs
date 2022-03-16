using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_racuna
{
    internal class LozinkaGenerator
    {
        public string GenerirajLozinku(string ime, string prezime)
        {
            return prezime + (ime.Length + prezime.Length);
        }
    }
}
