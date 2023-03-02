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
    public partial class FrmOtvoriDevizniRacun : Form
    {
        private Valuta _odabranaValuta;

        public IKorisnik OdabraniKorisnik { get; set; }

        public FrmOtvoriDevizniRacun(IKorisnik korisnik)
        {
            InitializeComponent();
            OdabraniKorisnik = korisnik;
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            string iban = ibanTextBox.Text;
            double stanje = double.Parse(stanjeTextBox.Text);
            OdabraniKorisnik.KreirajDevizniRacun(iban, stanje, _odabranaValuta.Naziv);
            Close();
        }

        private void odabirValuteButton_Click(object sender, EventArgs e)
        {
            FrmOdaberiValutu form = new FrmOdaberiValutu();
            form.ShowDialog();

            _odabranaValuta = form.OdabranaValuta;
            valutaTextBox.Text = _odabranaValuta.ToString();
        }

        private void InicijalizirajPodatke()
        {
            ibanTextBox.Text = GeneratorIBAN.DohvatiNovi();
            korisnikTextBox.Text = OdabraniKorisnik.Opis;
            stanjeTextBox.Text = "0";
        }

        private void FrmOtvoriDevizniRacun_Load(object sender, EventArgs e)
        {
            InicijalizirajPodatke();
        }
    }
}
