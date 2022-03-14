using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naslov knjige koju posudujete: ");
            string naslov = Console.ReadLine();
            Console.WriteLine("Unesite ime osobe kojoj posudujete knjigu: ");
            string imeOsobe = Console.ReadLine();
            Console.WriteLine("---------------------");
            Knjiznica k = new Knjiznica();
            k.Posudi(naslov, imeOsobe);
            Console.ReadKey();
        }
    }
}
