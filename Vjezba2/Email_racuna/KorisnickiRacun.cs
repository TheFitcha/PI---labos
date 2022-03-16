using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_racuna
{
    internal class KorisnickiRacun
    {
        private string ime, prezime, email, skraceniEmail, lozinka;
        public KorisnickiRacun(string ime, string prezime, string email, string skraceniEmail, string lozinka)
        {
            this.ime = ime; 
            this.prezime = prezime; 
            this.email = email;
            this.skraceniEmail = skraceniEmail;
            this.lozinka = lozinka;
        }

        public string Ime { get { return ime; } }
        public string Prezime { get { return prezime; } }   
        public string Email { get { return email; } }
        public string SkraceniEmail { get { return skraceniEmail; } }
        public string Lozinka { get { return lozinka; } }

    }
}
