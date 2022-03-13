using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_evidencija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor;
            Evidencija evidencija = new Evidencija();   
            do
            {
                Console.WriteLine("1. Dodavanje države i gradova");
                Console.WriteLine("2. Zapis trenutnog broja zaraženih u gradu");
                Console.WriteLine("3. Ispis stanja zaraženih");
                Console.WriteLine("9. Izlaz");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        evidencija.dodaj();
                        break;
                    case 2:
                        evidencija.dodajZarazene();
                        break;
                    case 3:
                        evidencija.ispisZarazenih(); 
                        break;
                }
            } while (izbor != 9);
        }
    }
}
