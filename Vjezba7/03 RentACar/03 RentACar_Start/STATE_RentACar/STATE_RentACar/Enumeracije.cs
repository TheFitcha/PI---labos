using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public enum StatusVozila
    {
        Raspoloziv, UKvaru, Rezerviran, UUporabi, NaPregledu
    }

    public enum Dogadaj
    {
        Kvar, PopravljenKvar, KlijentZatrazioVozilo, KlijentStigaoPoAuto, KlijentVracaAuto, VoziloSpremnoZaUporabu
    }
}
