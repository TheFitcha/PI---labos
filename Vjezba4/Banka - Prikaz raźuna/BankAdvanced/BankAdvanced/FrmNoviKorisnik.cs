using BankaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KorisniciLib;

namespace BankAdvanced
{
    public partial class FrmNoviKorisnik : Form
    {
        public FrmNoviKorisnik()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            Spremi();
            Close();
        }

        private void Spremi()
        {
            string oib = oibTextBox.Text;
            string poduzece = poduzeceTextBox.Text;
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;

            if (cmbVrstaKorisnika.SelectedIndex == 0)
            {
                KorisniciDB.KreirajObicnogKorisnika(oib, ime, prezime);
            }
            else
            {
                KorisniciDB.KreirajPremiumKorisnika(oib, poduzece, ime, prezime);
            }
        }

        private void cmbVrstaKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVrstaKorisnika.SelectedIndex == 0)
            {
                poduzeceTextBox.Enabled = false;
            }
            else
            {
                poduzeceTextBox.Enabled = true;
            }
        }
    }
}
