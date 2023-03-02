using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public class Vozilo
    {
        public string Registracija { get; set; }
        public string Model { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPredavanja { get; set; }
        public string PregledNapravio { get; set; }
        public StanjeAuta Stanje { get; set; }

        public Vozilo(string registracija, string model)
        {
            Registracija = registracija;
            Model = model;
            Stanje = new StanjeAuta();
        }

        public void RezervirajVozilo()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.KlijentZatrazioVozilo);
            DatumRezervacije = DateTime.Now;
        }

        public void PredajVozilo()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.KlijentStigaoPoAuto);
            DatumPredavanja = DateTime.Now;
        }

        public void PregledajVozilo(string pregledNapravio)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.KlijentVracaAuto);
            PregledNapravio = pregledNapravio;
        }

        public void AktivirajVozilo()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.PopravljenKvar);
        }

        public void DeaktivirajVozilo()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.Kvar);
        }

        public void UciniRaspolozivim()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.VoziloSpremnoZaUporabu);  
        }
    }
}
