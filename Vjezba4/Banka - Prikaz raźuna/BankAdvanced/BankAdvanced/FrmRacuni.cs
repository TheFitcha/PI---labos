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
    public partial class FrmRacuni : Form
    {
        public IKorisnik OdabraniKorisnik { get; set; }

        public FrmRacuni(IKorisnik korisnik)
        {
            InitializeComponent();  
            OdabraniKorisnik = korisnik;
        }

        private void btnPrikaziTransakcije_Click(object sender, EventArgs e)
        {
            IRacun racun = DohvatiSelektiraniRacun();
            PrikaziTransakcijeRacuna(racun);
        }

        private void PrikaziTransakcijeRacuna(IRacun racun)
        {
            FrmTransakcije form = new FrmTransakcije(racun);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private IRacun DohvatiSelektiraniRacun()
        {
            if (racuniDataGridView.CurrentRow != null)
            {
                return racuniDataGridView.CurrentRow.DataBoundItem as IRacun;
            }
            return null;
        }

        private void RacuniForm_Load(object sender, EventArgs e)
        {
            PrikaziRacuneKorisnika();
        }

        private void PrikaziRacuneKorisnika()
        {
            if (OdabraniKorisnik != null)
            {
                var racuniKorisnika = OdabraniKorisnik.DohvatiRacune();
                racuniDataGridView.DataSource = racuniKorisnika;
            }
        }

        private void btnNoviTekuciRacun_Click(object sender, EventArgs e)
        {
            var form = new FrmOtvoriTekuciRacun(OdabraniKorisnik);
            form.ShowDialog();
            PrikaziRacuneKorisnika();
        }

        private void btnNoviDevizniRacun_Click(object sender, EventArgs e)
        {
            var form = new FrmOtvoriDevizniRacun(OdabraniKorisnik);
            form.ShowDialog();
            PrikaziRacuneKorisnika();
        }
    }
}
