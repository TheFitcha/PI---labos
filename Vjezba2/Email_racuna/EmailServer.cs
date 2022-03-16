using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_racuna
{
    internal class EmailServer
    {
        public KorisnickiRacun KreirajKorisnickiRacun(string ime, string prezime)
        {
            EmailGenerator mailGenerator = new EmailGenerator();
            LozinkaGenerator lozinka = new LozinkaGenerator();
            return new KorisnickiRacun(ime, prezime, mailGenerator.GenerirajEmail(ime, prezime), 
                mailGenerator.GenerirajSkraceniEmail(ime, prezime), lozinka.GenerirajLozinku(ime, prezime));   
        }
    }
}
