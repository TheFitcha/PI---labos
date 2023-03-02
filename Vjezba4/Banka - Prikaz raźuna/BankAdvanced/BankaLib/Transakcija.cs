using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class Transakcija
    {
        public int Id { get; set; }
        [Browsable(false)]
        public IRacun IzvorisniRacun { get; set; }
        [Browsable(false)]
        public IRacun OdredisniRacun { get; set; }

        public string IzvorisniRacunOpis
        {
            get
            {
                if (IzvorisniRacun != null)
                {
                    return IzvorisniRacun.ToString();
                }
                return "";
            }
        }

        public string OdredisniRacunOpis
        {
            get
            {
                if (OdredisniRacun != null)
                {
                    return OdredisniRacun.ToString();
                }
                return "";
            }
        }

        private double _isplaceniIznos;

        public double IsplaceniIznos
        {
            get { return _isplaceniIznos; }
            set { _isplaceniIznos = Math.Round(value, 2); }
        }

        public double Iznos { get; set; }

        private double _uplaceniIznos;

        public double UplaceniIznos
        {
            get { return _uplaceniIznos; }
            set { _uplaceniIznos = Math.Round(value, 2); }
        }


        public bool Provedena { get; set; }
        public DateTime Datum { get; set; }

        public Transakcija(IRacun izvorisniRacun, IRacun odredisniRacun, double iznos)
        {
            Id = GetHashCode();
            IzvorisniRacun = izvorisniRacun;
            OdredisniRacun = odredisniRacun;
            Iznos = iznos;
            Datum = DateTime.Now;

            Provedena = false;
        }

        public void Izvrsi()
        {
            double iznosIsplate = IzracunajIznosIsplate();
            double iznosUplate = IzracunajIznosUplate();

            IzvorisniRacun.OduzmiIznos(iznosIsplate);
            OdredisniRacun.DodajIznos(iznosUplate);
            
            IsplaceniIznos = iznosIsplate;
            UplaceniIznos = iznosUplate;

            Provedena = true;
        }

        public void Ponisti()
        {
            IzvorisniRacun.DodajIznos(IsplaceniIznos);
            OdredisniRacun.OduzmiIznos(UplaceniIznos);
        }

        private double IzracunajIznosIsplate()
        {
            return Iznos;
        }

        private double IzracunajIznosUplate()
        {
            if (IzvorisniRacun.Valuta != OdredisniRacun.Valuta)
            {
                Mjenjacnica konverter = new Mjenjacnica();
                string izvorisnaValuta = IzvorisniRacun.Valuta.Naziv;
                string odredisnaValuta = OdredisniRacun.Valuta.Naziv;
                return konverter.PromijeniNovac(izvorisnaValuta, odredisnaValuta , Iznos);
                
            }
            else
            {
                return Iznos;
            }
        }
    }
}
