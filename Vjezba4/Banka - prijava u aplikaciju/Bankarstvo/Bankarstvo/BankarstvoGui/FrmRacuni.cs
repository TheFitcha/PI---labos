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
    public partial class FrmRacuni : Form
    {
        public FrmRacuni()
        {
            InitializeComponent();
        }

        private void FrmRacuni_Load(object sender, EventArgs e)
        {
            PrikaziSveRacune();
        }

        private void PrikaziSveRacune()
        {
            var klijent = Autentifikator.PrijavljeniKorisnik.Klijent;
            dgvRacuni.DataSource = klijent.DohvatiSveRacune();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPregledTransakcija_Click(object sender, EventArgs e)
        {
            var odabraniRacun = DohvatiOdabraniRacun();
            var formaTransakcija = new FrmTransakcije(odabraniRacun);
            formaTransakcija.ShowDialog();
            PrikaziSveRacune();
        }

        private Racun DohvatiOdabraniRacun()
        {
            Racun racun = null;

            if (dgvRacuni.CurrentRow != null)
            {
                racun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
            }

            return racun;
        }
    }
}
