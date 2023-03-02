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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            Autentifikator.Prijavi(korisnickoIme, lozinka);

            if (Autentifikator.PrijavljeniKorisnik != null)
            {
                Close();
            }
            else
            {
                PonovniPokusaj();
            }
            
        }

        private void PonovniPokusaj()
        {
            OcistiUnos();
            MessageBox.Show("Unijeti podaci nisu ispravni, molimo vas pokušajte ponovno!");
        }

        private void OcistiUnos()
        {
            txtKorisnickoIme.Clear();
            txtLozinka.Clear();
        }
    }
}
