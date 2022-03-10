using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrijeme_u_gradu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gradovi = new string[6]
            {
                "Santiago",
                "Salvador",
                "London",
                "Zagreb",
                "Damask",
                "Istanbul"
            };
            string[] vremenskeZone = new string[6]
            {
                "UTC-4",
                "UTC-3",
                "UTC+0",
                "UTC+1",
                "UTC+2",
                "UTC+3"
            };

            Console.WriteLine("Unesite naziv grada: ");
            string unos = Console.ReadLine();
            DateTime utcVrijeme = DateTime.UtcNow;

            if (gradovi.Contains(unos))
            {
                int index = Array.IndexOf(gradovi, unos);
                if (vremenskeZone[index].Contains('+'))
                {
                    utcVrijeme = utcVrijeme.AddHours(int.Parse(vremenskeZone[index].Substring(4)));
                }
                else
                {
                    utcVrijeme = utcVrijeme.AddHours(-int.Parse(vremenskeZone[index].Substring(4)));
                }
                Console.WriteLine($"Trenutno vrijeme u gradu {unos} je: {utcVrijeme:H:mm}");
            }
            else
            {
                Console.WriteLine("Grad ne postoji!");
            }
            Console.ReadKey();
        }
    }
}
