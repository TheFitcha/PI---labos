using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public class StanjeAuta
    {
        public StatusVozila TrenutniStatus { get; set; }
        private Dictionary<Prijelaz, StatusVozila> dozvoljeniPrijelazi { get; set; }
        public StanjeAuta()
        {
            TrenutniStatus = StatusVozila.Raspoloziv;
            DefinirajDozvoljenePrijelaze();
        }

        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, StatusVozila>()
            {
                { new Prijelaz(StatusVozila.Raspoloziv, Dogadaj.Kvar), StatusVozila.UKvaru },
                { new Prijelaz(StatusVozila.UKvaru, Dogadaj.PopravljenKvar), StatusVozila.Raspoloziv },
                { new Prijelaz(StatusVozila.Raspoloziv, Dogadaj.KlijentZatrazioVozilo), StatusVozila.Rezerviran},
                { new Prijelaz(StatusVozila.Rezerviran, Dogadaj.KlijentStigaoPoAuto), StatusVozila.UUporabi },
                { new Prijelaz(StatusVozila.UUporabi, Dogadaj.KlijentVracaAuto), StatusVozila.NaPregledu },
                { new Prijelaz(StatusVozila.NaPregledu, Dogadaj.VoziloSpremnoZaUporabu), StatusVozila.Raspoloziv }
            };
        }

        public void IzvrsiPrijelaz(Dogadaj aktivacijskiDogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutniStatus, aktivacijskiDogadaj);

            if (dozvoljeniPrijelazi.TryGetValue(prijelaz, out StatusVozila odredisniStatus) == false)
            {
                throw new Exception("Neispravan prijelaz!");
            }
            TrenutniStatus = odredisniStatus;
        }
    }
}
