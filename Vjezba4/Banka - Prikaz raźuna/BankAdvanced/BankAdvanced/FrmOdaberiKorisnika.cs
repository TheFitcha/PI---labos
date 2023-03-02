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
    public partial class FrmOdaberiKorisnika : Form
    {
        public IKorisnik OdabraniKorisnik { get; set; }

        public FrmOdaberiKorisnika()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            OdabraniKorisnik = null;
            Close();
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            OdabraniKorisnik = DohvatiOdabranogKorisnika();
            Close();
        }

        private IKorisnik DohvatiOdabranogKorisnika()
        {
            if (korisniciDataGridView.CurrentRow != null)
            {
                return korisniciDataGridView.CurrentRow.DataBoundItem as IKorisnik;
            }
            return null;
        }

        private void FrmOdaberiKorisnika_Load(object sender, EventArgs e)
        {
            korisniciDataGridView.DataSource = KorisniciDB.VratiSveKorisnike();
        }
    }
}
