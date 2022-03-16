using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string korisnickoIme, lozinka;
            Console.WriteLine("PRIJAVA U SUSTAV\n----------------------------\nKorisničko ime:");
            korisnickoIme = Console.ReadLine();
            Console.WriteLine("Lozinka:");
            lozinka = Console.ReadLine();
            Autentifikator autentifikator = new Autentifikator();
            Console.WriteLine($"{autentifikator.PrijaviKorisnika(korisnickoIme, lozinka)}");
            Console.ReadKey();
        }
    }
}
