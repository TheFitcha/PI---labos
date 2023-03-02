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

namespace BankAdvanced
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void popisTransakcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmTransakcije();
            form.MdiParent = this;
            form.Show();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
           
        }

        private void pregledTečajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmPregledTecaja();
            form.MdiParent = this;
            form.Show();
        }

        private void popisValutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmPopisValuta();
            form.MdiParent = this;
            form.Show();
        }

        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmKorisnici();
            form.MdiParent = this;
            form.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmNoviKorisnik();
            form.MdiParent = this;
            form.Show();
        }
    }
}
