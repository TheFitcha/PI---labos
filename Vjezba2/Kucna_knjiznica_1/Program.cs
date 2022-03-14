using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ISBN;
            Knjiznica k = new Knjiznica();
            while (true)
            {
                Console.WriteLine("Unesite ISBN knjige koju posudujete: ");
                ISBN = Console.ReadLine();
                k.Posudi(ISBN);
            }
        }
    }
}
