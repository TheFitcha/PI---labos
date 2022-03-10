using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost_osobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mjeseci = new Dictionary<string, int>()
            {
                {"sijecanj", 1},
                {"veljaca", 2},
                {"ozujak", 3},
                {"travanj", 4},
                {"svibanj", 5},
                {"lipanj", 6},
                {"srpanj", 7},
                {"kolovoz", 8},
                {"rujan", 9},
                {"listopad", 10},
                {"studeni", 11},
                {"prosinac", 12}
            };
            Console.WriteLine("IZRAČUN STAROSTI OSOBE:\n---------------------------------------------------");
            Console.WriteLine("Upišite datum rođenja u formatu \"dd mmmm yyyy\" (npr. 20 siječanj 1995): ");
            string datum = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------");

            string[] razdvojeniDatum = datum.Split(' ');
            DateTime danasnjiDatum = DateTime.Now;
            DateTime uneseniDatum = new DateTime(Convert.ToInt32(razdvojeniDatum[2]), mjeseci[razdvojeniDatum[1]], Convert.ToInt32(razdvojeniDatum[0]));

            if (danasnjiDatum.Month > uneseniDatum.Month || (danasnjiDatum.Month == uneseniDatum.Month && danasnjiDatum.Day > uneseniDatum.Day))
            {
                Console.WriteLine($"Dana {uneseniDatum.Date.ToString("dd.MM.")}{danasnjiDatum.Year} ste napunili {danasnjiDatum.Year - uneseniDatum.Year} godina!");
            }
            else
            {
                Console.WriteLine($"Dana {uneseniDatum.Date.ToString("dd.MM.")}{danasnjiDatum.Year} ćete napuniti {danasnjiDatum.Year - uneseniDatum.Year} godina!");
            }
            Console.ReadKey();
        }    
    }
}
