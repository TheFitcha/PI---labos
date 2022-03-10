using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svjetsko_vrijeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vrijeme = new List<string>()
            {
                "Santiago;-4",
                "Salvador;-3",
                "London;+0",
                "Zagreb;+1",
                "Damask;+2",
                "Istanbul;+3"
            };
            DateTime trenutnoSat = DateTime.UtcNow;
            foreach(string v in vrijeme)
            {
                string[] rastavljeno = v.Split(';');
                DateTime izracunatiSat;
                if (rastavljeno[1][0] == '+')
                {
                    izracunatiSat = trenutnoSat.AddHours(Convert.ToInt32(rastavljeno[1][1]));
                }
                else
                {
                    izracunatiSat = trenutnoSat.AddHours(-Convert.ToInt32(rastavljeno[1][1]));
                }
                Console.WriteLine($"Trenutno vrijeme za {rastavljeno[0]} je: {izracunatiSat:H:mm}");
            }
            Console.ReadKey();
        }
    }
}
