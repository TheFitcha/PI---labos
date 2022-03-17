using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Prvenstvo
    {
        private List<Reprezentacija> reprezentacije = new List<Reprezentacija>();
        private List<Utakmica> utakmice = new List<Utakmica>();

        public void dodajReprezentaciju(string naziv, string oznaka)
        {
            reprezentacije.Add(new Reprezentacija(naziv, oznaka));
            foreach(Reprezentacija reprezentacija in reprezentacije) { Console.WriteLine(reprezentacija.Naziv); }
        }
        public void dodajUtakmicu(string domacin, string gostujuci, int goloviDomaci, int goloviGosti)
        {
            Reprezentacija domaci = reprezentacije.Find(x => x.Naziv == domacin);
            Reprezentacija gost = reprezentacije.Find(x => x.Naziv == gostujuci);
            utakmice.Add(new Utakmica(domaci, gost, goloviDomaci, goloviGosti));
        }

        public void IspisTabliceRezultata()
        {
            foreach(Utakmica utakmica in utakmice)
            {
                Console.WriteLine(utakmica.GenerirajIspis());
            }
        }

        public void GenerirajTablicuRezultata()
        {
            foreach(Utakmica utakmica in utakmice)
            {
                Console.WriteLine($"{utakmica.GenerirajIspis()}");
            }
        }

        public void GenerirajBodovnuLjestvicu()
        {
            Console.WriteLine("BODOVNA LJESTVICA\n" +
                "------------------------------------------\n" +
                "REP  OU  POB  NER  IZG  POZ  PRZ  RUZ  BOD\n" +
                "------------------------------------------");
            foreach(Reprezentacija reprezentacija in reprezentacije)
            {
                Console.WriteLine($"{reprezentacija.Oznaka}   {Odredi_OU(reprezentacija)}    {Odredi_POB(reprezentacija)}" +
                    $"    {Odredi_NER(reprezentacija)}    {Odredi_IZG(reprezentacija)}    {Odredi_POZ(reprezentacija)}" +
                    $"    {Odredi_PRZ(reprezentacija)}    {Odredi_RAZ(reprezentacija)}    {Odredi_BRB(reprezentacija)}");
            }
        }

        private int Odredi_OU(Reprezentacija reprezentacija)
        {
            int brojac = 0;
            foreach(Utakmica utakmica in utakmice)
            {
                if(utakmica.Domacin.Naziv == reprezentacija.Naziv || utakmica.Gostujuci.Naziv == reprezentacija.Naziv)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        private int Odredi_POB(Reprezentacija reprezentacija)
        {
            int brojac = 0;
            foreach(Utakmica utakmica in utakmice)
            {
                if(utakmica.Domacin.Naziv == reprezentacija.Naziv && utakmica.GoloviDomacin > utakmica.GoloviGostujuci)
                {
                    brojac++;
                }
                else if(utakmica.Gostujuci.Naziv == reprezentacija.Naziv && utakmica.GoloviGostujuci > utakmica.GoloviDomacin)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        private int Odredi_NER(Reprezentacija reprezentacija)
        {
            int brojac = 0;
            foreach(Utakmica utakmica in utakmice)
            {
                if((utakmica.Domacin.Naziv == reprezentacija.Naziv || utakmica.Gostujuci.Naziv == reprezentacija.Naziv) && utakmica.GoloviDomacin == utakmica.GoloviGostujuci)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        private int Odredi_IZG(Reprezentacija reprezentacija)
        {
            int brojac = 0;
            foreach(Utakmica utakmica in utakmice)
            {
                if (utakmica.Domacin.Naziv == reprezentacija.Naziv && utakmica.GoloviDomacin < utakmica.GoloviGostujuci)
                {
                    brojac++;
                }
                else if (utakmica.Gostujuci.Naziv == reprezentacija.Naziv && utakmica.GoloviGostujuci < utakmica.GoloviDomacin)
                {
                    brojac++;
                }
            }
            return brojac;
        }
        private int Odredi_POZ(Reprezentacija reprezentacija)
        {
            int brojGolova = 0;
            foreach(Utakmica utakmica in utakmice)
            {
                if(utakmica.Domacin.Naziv == reprezentacija.Naziv)
                {
                    brojGolova += utakmica.GoloviDomacin;
                }
                else
                {
                    brojGolova += utakmica.GoloviGostujuci;
                }
            }
            return brojGolova;
        }

        private int Odredi_PRZ(Reprezentacija reprezentacija)
        {
            int primljeniGolovi = 0;
            foreach (Utakmica utakmica in utakmice)
            {
                if (utakmica.Domacin.Naziv == reprezentacija.Naziv)
                {
                    primljeniGolovi += utakmica.GoloviGostujuci;
                }
                else
                {
                    primljeniGolovi += utakmica.GoloviDomacin;
                }
            }
            return primljeniGolovi;
        }

        private int Odredi_RAZ(Reprezentacija reprezentacija)
        {
            return Odredi_POZ(reprezentacija) - Odredi_PRZ(reprezentacija);
        }

        private int Odredi_BRB(Reprezentacija reprezentacija)
        {
            return Odredi_POB(reprezentacija) * 3 + Odredi_NER(reprezentacija);
        }
    }
}
