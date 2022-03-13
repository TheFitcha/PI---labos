using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_evidencija
{
    internal class Evidencija
    {
        private List<Drzava> popisDrzava = new List<Drzava>();
        private List<Grad> popisGradova = new List<Grad>();
        private List<ZapisZarazenih> popisZapisa = new List<ZapisZarazenih>();

        private bool nadiDrzavu(string drzava)
        {
            foreach(Drzava dr in popisDrzava)
            {
                if(dr.NazivDrzave == drzava)
                {
                    return true;
                }
            }
            return false;
        }

        private bool nadiGrad(string grad)
        {
            foreach(Grad gr in popisGradova)
            {
                if(gr.NazivGrada == grad)
                {
                    return true;
                }
            }
            return false;
        }

        public void dodaj()
        {
            Console.WriteLine("Unesite drzavu: ");
            string drzava = Console.ReadLine();
            Drzava novaDrzava;
            if (!nadiDrzavu(drzava))
            {
                novaDrzava = new Drzava(drzava);
                popisDrzava.Add(novaDrzava);    
            }
            else
            {
                Console.WriteLine("Drzava vec postoji!");
                novaDrzava = popisDrzava.Find(x => x.NazivDrzave == drzava);
            }
            dodajGrad(novaDrzava);
        }

        private void dodajGrad(Drzava drzava)
        {
            string unosGrad = "";
            do
            {
                Console.WriteLine("Unesite naziv grada (' ' za prekid): ");
                unosGrad = Console.ReadLine();
                if (!nadiGrad(unosGrad))
                {
                    popisGradova.Add(new Grad(drzava, unosGrad));
                }
                else
                {
                    Console.WriteLine("Grad vec postoji!");
                }
            } while (unosGrad != " ");
        }

        public void dodajZarazene()
        {
            Console.WriteLine("Unesite drzavu: ");
            string drzava = Console.ReadLine();
            if (!nadiDrzavu(drzava))
            {
                Console.WriteLine("Ne postoji ta drzava!");
                return;
            }
            Console.WriteLine("Unesite grad: ");
            string grad = Console.ReadLine();
            if (!nadiGrad(grad))
            {
                Console.WriteLine("Ne postoji taj grad!");
                return;
            }
            Console.WriteLine("Unesite broj zarazenih: ");
            int brZarazenih = int.Parse(Console.ReadLine());
            popisZapisa.Add(new ZapisZarazenih(popisGradova.Find(x => x.NazivGrada == grad), brZarazenih));
        }
        public void ispisZarazenih()
        {
            Console.WriteLine("Unesite drzavu: ");
            string drzava = Console.ReadLine();
            if (!nadiDrzavu(drzava))
            {
                Console.WriteLine("Unesena drzava ne postoji!");
                return;
            }
            Console.WriteLine("Unesite grad: ");
            string grad = Console.ReadLine();
            if (!nadiGrad(grad))
            {
                Console.WriteLine("Uneseni grad ne postoji!");
                return;
            }
            foreach(ZapisZarazenih zapis in popisZapisa)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"{zapis.Grad.Drzava} - {zapis.Grad.NazivGrada} : {zapis.BrojZarazenih} ({zapis.Vrijeme})");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
