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
    public partial class FrmKorisnici : Form
    {
        public FrmKorisnici()
        {
            InitializeComponent();
        }

        private void FrmKorisnici_Load(object sender, EventArgs e)
        {
            PrikaziSveKorisnike();
        }

        private void PrikaziSveKorisnike()
        {
            dgvKorisnici.DataSource = KorisniciDB.VratiSveKorisnike();
        }

        private void detaljiButton_Click(object sender, EventArgs e)
        {
            var korisnik = DohvatiKorisnika();
            PrikaziDetaljeKorisnika(korisnik);

            PrikaziSveKorisnike();
        }

        private static void PrikaziDetaljeKorisnika(IKorisnik korisnik)
        {
            var form = new FrmProfilKorisnika(korisnik);
            form.ShowDialog();
        }

        private IKorisnik DohvatiKorisnika()
        {
            IKorisnik korisnik = null;
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as IKorisnik;
            }
            return korisnik;
        }

        private void btnPrikaziRacune_Click(object sender, EventArgs e)
        {
            var odabraniKorisnik = DohvatiKorisnika();
            var form = new FrmRacuni(odabraniKorisnik);
            form.ShowDialog();
        }
    }
}
