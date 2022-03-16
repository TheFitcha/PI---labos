using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_racuna
{
    internal class EmailGenerator
    {
        public string GenerirajEmail(string ime, string prezime)
        {
            return $"{ime}.{prezime}@foi.hr".ToLower();
        }

        public string GenerirajSkraceniEmail(string ime, string prezime)
        {
            return $"{ime.Substring(0, 1)}{prezime.Substring(0, 5)}@foi.hr".ToLower();
        }
    }
}
