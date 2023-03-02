using BankaLib;
using KorisniciLib;
using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    public partial class FrmOtvoriTekuciRacun : Form
    {
        public IKorisnik odabraniKorisnik { get; set; }

        public FrmOtvoriTekuciRacun(IKorisnik korisnik)
        {
            InitializeComponent();
            odabraniKorisnik = korisnik;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            string iban = ibanTextBox.Text;
            double stanje = double.Parse(stanjeTextBox.Text);
            double odobreniMinus = double.Parse(dozvoljeniMinusTextBox.Text);
            odabraniKorisnik.KreirajTekuciRacun(iban, stanje, odobreniMinus);
            Close();
        }

        private void FrmOtvoriTekuciRacun_Load(object sender, EventArgs e)
        {
            InicijalizirajPodatke();
        }

        private void InicijalizirajPodatke()
        {
            ibanTextBox.Text = GeneratorIBAN.DohvatiNovi();
            korisnikTextBox.Text = odabraniKorisnik.Opis;
            Valuta hrk = MjenjacnicaDB.VratiValutuPoNazivu("HRK");
            valutaTextBox.Text = hrk.ToString();
            stanjeTextBox.Text = "0";
            dozvoljeniMinusTextBox.Text = "0";
        }
    }
}
