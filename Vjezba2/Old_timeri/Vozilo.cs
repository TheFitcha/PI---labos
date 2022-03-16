using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_timeri
{
    enum Tip
    {
        automobil,
        motocikl
    }
    abstract class Vozilo
    {
        public string naziv;
        public Tip tipVozila;
    }
}
