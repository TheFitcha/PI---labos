using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos;
            Hotel h = new Hotel();
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                unos = Console.ReadLine();
                Console.WriteLine(unos.Split(' ')[0]);
                switch (unos.Split(' ')[0])
                {
                    case "#pronadji":
                        foreach(Soba s in h.PronadjiSobe(int.Parse(unos.Split(' ')[1])))
                        {
                            Console.WriteLine($"Oznaka: {s.Oznaka}, Kapacitet: {s.Kapacitet}");
                        };
                        break;
                    case "#rezerviraj":
                        h.RezervirajSobu(unos.Split(' ')[1]);
                        break;
                }
            } while (unos != "#exit");
        }
    }
}
