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
    public partial class FrmOdaberiRacun : Form
    {
        public IRacun OdabraniRacun { get; set; }
        private IKorisnik _korisnik;

        public FrmOdaberiRacun(IKorisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void FrmOdaberiRacun_Load(object sender, EventArgs e)
        {
            racunDataGridView.DataSource = _korisnik.DohvatiRacune();
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            OdabraniRacun = DohvatiSelektiranogRacuna();
            Close();
        }

        private IRacun DohvatiSelektiranogRacuna()
        {
            if (racunDataGridView.CurrentRow != null)
            {
                return racunDataGridView.CurrentRow.DataBoundItem as IRacun;
            }
            return null;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            OdabraniRacun = null;
            Close();
        }
    }
}
