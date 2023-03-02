using BankaLib;
using BankaLib.Iznimke;
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
    public partial class FrmNovaTransakcija : Form
    {
        private IKorisnik _izvorisniKorisnik;
        private IRacun _izvorisniRacun;

        private IKorisnik _odredisniKorisnik;
        private IRacun _odredisniRacun;

        public FrmNovaTransakcija()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void racunPlatiteljButton_Click(object sender, EventArgs e)
        {
            if (_izvorisniKorisnik != null)
            {
                FrmOdaberiRacun form = new FrmOdaberiRacun(_izvorisniKorisnik);
                form.ShowDialog();

                _izvorisniRacun = form.OdabraniRacun;
                PrikaziIzvorisniRacun();
            }
            else
            {
                MessageBox.Show("Prvo morate odabrati korisnika!");
            }
        }

        private void PrikaziIzvorisniRacun()
        {
            if (_izvorisniRacun != null)
            {
                racunIzvorisniTextBox.Text = _izvorisniRacun.ToString();
            }
            else
            {
                racunIzvorisniTextBox.Text = "";
            }
        }

        private void racunPrimateljButton_Click(object sender, EventArgs e)
        {
            if (_odredisniKorisnik != null)
            {
                FrmOdaberiRacun form = new FrmOdaberiRacun(_odredisniKorisnik);
                form.ShowDialog();

                _odredisniRacun = form.OdabraniRacun;
                PrikaziOdredisniRacun();
            }
            else
            {
                MessageBox.Show("Prvo morate odabrati korisnika!");
            }
        }

        private void PrikaziOdredisniRacun()
        {
            if (_odredisniRacun != null)
            {
                racunOdredisniTextBox.Text = _odredisniRacun.ToString();
            }
            else
            {
                racunOdredisniTextBox.Text = "";
            }
        }

        private void korisnikIzvorisniButton_Click(object sender, EventArgs e)
        {
            FrmOdaberiKorisnika form = new FrmOdaberiKorisnika();
            form.ShowDialog();

            _izvorisniKorisnik = form.OdabraniKorisnik;
            PrikaziIzvorisnogKorisnika();
        }

        private void PrikaziIzvorisnogKorisnika()
        {
            if (_izvorisniKorisnik != null)
            {
                korisnikIzvorisniTextBox.Text = _izvorisniKorisnik.Opis;
            }
            else
            {
                korisnikIzvorisniTextBox.Text = "";
            }
        }

        private void korisnikOdredisniButton_Click(object sender, EventArgs e)
        {
            FrmOdaberiKorisnika form = new FrmOdaberiKorisnika();
            form.ShowDialog();

            _odredisniKorisnik = form.OdabraniKorisnik;
            PrikaziOdredisnogKorisnika();
        }

        private void PrikaziOdredisnogKorisnika()
        {
            if (_odredisniKorisnik != null)
            {
                korisnikOdredisniTextBox.Text = _odredisniKorisnik.Opis;
            }
            else
            {
                korisnikOdredisniTextBox.Text = "";
            }
        }

        private void provediButton_Click(object sender, EventArgs e)
        {
            try
            {
                double iznos = double.Parse(iznosTextBox.Text);
                _izvorisniRacun.IzvrsiIsplatu(_odredisniRacun, iznos);
                Close();
            }
            catch (TransactionException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
