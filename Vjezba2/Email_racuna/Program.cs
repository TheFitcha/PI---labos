using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_racuna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otvaranje email korisničkog računa:\n---------------------------\nUnesite vaše ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite vaše prezime:");
            string prezime = Console.ReadLine();
            EmailServer server = new EmailServer();
            KorisnickiRacun racun = server.KreirajKorisnickiRacun(ime, prezime);
            Console.WriteLine($"Podaci za vaš mail korisnički račun su sljedeći:\nIme: {racun.Ime}\nPrezime: {racun.Prezime}" +
                $"\nEmail: {racun.Email}\nEmail skraćeni: {racun.SkraceniEmail}\nLozinka: {racun.Lozinka}");
            Console.ReadKey();
        }
    }
}
