using BankaLib;
using KorisniciLib;
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
    public partial class FrmProfilKorisnika : Form
    {
        public IKorisnik Korisnik { get; private set; }

        public FrmProfilKorisnika(IKorisnik korisnik)
        {
            InitializeComponent();
            Korisnik = korisnik;
        }

        private void FrmProfilKorisnika_Load(object sender, EventArgs e)
        {
            PrikaziProfil();
        }

        private void PrikaziProfil()
        {
            if (Korisnik.Vrsta == VrstaKorisnika.Obicni)
            {
                PrikaziObicnogKorisnika(Korisnik as ObicniKorisnik);
            }
            else
            {
                PrikaziPremiumKorisnika(Korisnik as PremiumKorisnik);
            }
        }

        private void PrikaziObicnogKorisnika(ObicniKorisnik korisnik)
        {
            oibTextBox.Text = korisnik.OIB;
            imeTextBox.Text = korisnik.Ime;
            prezimeTextBox.Text = korisnik.Prezime;
            cmbVrstaKorisnika.SelectedIndex = 0;
            poduzeceTextBox.Enabled = false;
        }

        private void PrikaziPremiumKorisnika(PremiumKorisnik korisnik)
        {
            oibTextBox.Text = korisnik.OIB;
            imeTextBox.Text = korisnik.Ime;
            prezimeTextBox.Text = korisnik.Prezime;
            cmbVrstaKorisnika.SelectedIndex = 1;
            poduzeceTextBox.Text = korisnik.NazivPoduzeca;
            poduzeceTextBox.Enabled = true;
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            SpremiKorisnika();
            Close();
        }

        private void SpremiKorisnika()
        {
            if (Korisnik.Vrsta == VrstaKorisnika.Obicni)
            {
                SpremiObisnogKorisnika(Korisnik as ObicniKorisnik);
            }
            else
            {
                SpremiPreimumKorisnika(Korisnik as PremiumKorisnik);
            }
        }

        private void SpremiPreimumKorisnika(PremiumKorisnik korisnik)
        {
            korisnik.OIB = oibTextBox.Text;
            korisnik.Ime = imeTextBox.Text;
            korisnik.Prezime = prezimeTextBox.Text;
            korisnik.NazivPoduzeca = poduzeceTextBox.Text;
        }

        private void SpremiObisnogKorisnika(ObicniKorisnik korisnik)
        {
            korisnik.OIB = oibTextBox.Text;
            korisnik.Ime = imeTextBox.Text;
            korisnik.Prezime = prezimeTextBox.Text;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
