using BankarstvoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankarstvoGui
{
    public partial class FrmProfilKorisnika : Form
    {
        public FrmProfilKorisnika()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProfilKorisnika_Load(object sender, EventArgs e)
        {
            PrikaziProfilnePodatke();
        }

        private void PrikaziProfilnePodatke()
        {
            var korisnickiRacun = Autentifikator.PrijavljeniKorisnik;
            var klijent = korisnickiRacun.Klijent;

            txtOIB.Text = klijent.OIB;
            txtIme.Text = klijent.Ime;
            txtPrezime.Text = klijent.Prezime;

            txtKorisnickoIme.Text = korisnickiRacun.KorisnickoIme;
            txtLozinka.Text = korisnickiRacun.Lozinka;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var korisnickiRacun = Autentifikator.PrijavljeniKorisnik;
            korisnickiRacun.Lozinka = txtLozinka.Text;
            Close();
        }
    }
}
