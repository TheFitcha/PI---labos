using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos;
            Prvenstvo prvenstvo = new Prvenstvo();
            do
            {
                Console.WriteLine("PRVENSTVO APP\n" +
                    "--------------------------------\n" + 
                    "[1] Unesi reprezentaciju\n" +
                    "[2] Evidentiraj utakmicu\n" +
                    "[3] Ispiši tablicu rezultata\n" +
                    "[4] Ispiši bodovnu ljestvicu\n" +
                    "[0] Izlaz" +
                    "\n--------------------------------");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        Console.WriteLine("Unesite naziv reprezentacije:");
                        string naziv = Console.ReadLine();
                        Console.WriteLine("Unesite oznaku reprezentacije:");
                        string oznaka = Console.ReadLine();
                        prvenstvo.dodajReprezentaciju(naziv, oznaka);
                        break;
                    case "2":
                        Console.WriteLine("Unesite naziv domace reprezentacije:");
                        string nazivDomaci = Console.ReadLine();
                        Console.WriteLine("Unesite naziv gostujuce reprezentacije:");
                        string nazivGosti = Console.ReadLine();
                        Console.WriteLine("Unesite broj golova za domace:");
                        int brGolovaDomaci = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite broj golova za gostujuce:");
                        int brGolovaGosti = int.Parse(Console.ReadLine());     
                        prvenstvo.dodajUtakmicu(nazivDomaci, nazivGosti, brGolovaDomaci, brGolovaGosti);
                        break;
                    case "3":
                        prvenstvo.IspisTabliceRezultata();
                        break;
                    case "4":
                        prvenstvo.GenerirajBodovnuLjestvicu();
                        break;
                }
            } while (unos != "0");
        }
    }
}
